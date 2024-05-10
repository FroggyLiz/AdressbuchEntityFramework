using AdressbuchEntityFramework.Model;
using AdressbuchEntityFramework.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdressbuchEntityFramework;

internal partial class Form1 : Form
{
   #region Variables

   private CancellationTokenSource _cts = new CancellationTokenSource();

   #endregion

   #region Constructor

   /// <summary>
   /// Constructor that Initializes this Component
   /// </summary>
   internal Form1()
   {
      InitializeComponent();
   }

   #endregion

   #region Event-Methods

   /// <summary>
   /// Executes when the Search Button is Clicked
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void searchButton_Click(object sender, EventArgs e)
   {
      //Execute as Seperate Task to prevent Locking up UI
      Task.Run(async () =>
      {
         await SearchAndShowWithCancel(this.searchtermTextBox.Text);
      });
   }

   /// <summary>
   /// Executes when the Cancel Search Button is clicked
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void cancelSearchButton_Click(object sender, EventArgs e)
   {
      //Cancel the Search
      _cts.Cancel();
   }

   /// <summary>
   /// Opens the Form for the Edit of a new AdressEintrag
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private async void neuEintragButton_Click(object sender, EventArgs e)
   {
      using var addEintragForm = new AddAdressEintragForm();
      addEintragForm.ShowDialog();
      if (addEintragForm.Eintrag is null)
      {
         //Dont save
         return;
      }

      await AddAdressEintrag(addEintragForm.Eintrag);
   }

   #endregion

   #region Methods

   #region DB-Interaction

   /// <summary>
   /// Searches an AdressEintrag in the Database
   /// </summary>
   /// <param name="search"></param>
   /// <param name="token"></param>
   /// <returns></returns>
   private async Task<AdressEintrag?> SearchAdressEintrag(string search, CancellationToken token)
   {
      var context = new AppDbContext();

      return await context.AdressEinträge.Include(x => x.Adressen)
         .FirstOrDefaultAsync(x => EF.Functions.Like(x.Name, search), token);
   }

   /// <summary>
   /// Adds an AdressEintrag into the Database
   /// </summary>
   /// <param name="eintrag"></param>
   /// <returns></returns>
   private async Task AddAdressEintrag(AdressEintrag eintrag)
   {
      var context = new AppDbContext();
      await context.AdressEinträge.AddAsync(eintrag);
      await context.SaveChangesAsync();
   }

   #endregion

   /// <summary>
   /// Searches the DB for the Given string, and shows the Element
   /// </summary>
   /// <param name="search"></param>
   /// <returns></returns>
   private async Task SearchAndShowWithCancel(string search)
   {
      //Reset CancellationToken
      _cts = new CancellationTokenSource();

      var element = await SearchAdressEintrag(search, _cts.Token);
      if (element is null)
      {
         MessageBox.Show($"Unter '{search}' wird kein Eintrag gefunden!",
            "Kein Eintrag gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);

         return;
      }

      this.ShowElement(element);
   }

   /// <summary>
   /// Shows the AdressEintrag Element in the UI Thread
   /// </summary>
   /// <param name="eintrag"></param>
   private void ShowElement(AdressEintrag eintrag)
   {
      //Invoke to the UI Thread
      this.nameLabel.InvokeTextToUI(eintrag.Name);
      this.geburtstagLabel.InvokeTextToUI(eintrag.Geburtstag.ToShortDateString());
      this.telefonnrLabel.InvokeTextToUI(eintrag.TelefonNummer);
      this.adressenLabel.InvokeTextToUI(ComputeAdressesToString(eintrag.Adressen));
   }

   /// <summary>
   /// Converts a List of Adresses to a string
   /// </summary>
   /// <param name="adressen"></param>
   /// <returns></returns>
   private string ComputeAdressesToString(IEnumerable<Adresse> adressen)
   {
      return string.Join("\n", adressen);
   }

   #endregion
}