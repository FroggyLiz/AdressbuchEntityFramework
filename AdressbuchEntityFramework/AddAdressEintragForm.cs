using AdressbuchEntityFramework.Model.Entities;

namespace AdressbuchEntityFramework;

internal partial class AddAdressEintragForm : Form
{
   #region Variables

   internal AdressEintrag? Eintrag;
   private HashSet<Adresse> _adressen = new();

   #endregion

   #region Constructor

   /// <summary>
   /// Constructor that Initializes this Component
   /// </summary>
   internal AddAdressEintragForm()
   {
      InitializeComponent();
   }

   #endregion

   #region Event-Methods

   /// <summary>
   /// When the Save Button is Clicked, Add all Values to the public Object
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void saveButton_Click(object sender, EventArgs e)
   {
      this.Eintrag = new ();
      this.Eintrag.Geburtstag = this.geburtstagDatePicker.Value;
      this.Eintrag.TelefonNummer = this.textBoxTelNr.Text;
      this.Eintrag.Name = this.textBoxName.Text;
      this.Eintrag.Adressen = this._adressen;

      this.Close();
   }

   /// <summary>
   /// When the Cancel Button is Clicked, set the public Object to null
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void cancelButton_Click(object sender, EventArgs e)
   {
      this.Eintrag = null;
      this.Close();
   }

   /// <summary>
   /// When the AddAdresse Button is Clicked, Open a new AddAdresseForm
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void buttonAddAdresse_Click(object sender, EventArgs e)
   {
      using var addAdresseForm = new AddAdresseForm();
      addAdresseForm.ShowDialog();
      if(addAdresseForm.Adresse is null)
      {
         //Dont Add
         return;
      }

      this._adressen.Add(addAdresseForm.Adresse);
      this.listBoxAdressen.Items.Add(addAdresseForm.Adresse);
   }

   /// <summary>
   /// When the RemoveAdresse Button is Clicked, Remove the current Selected Adresse
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void buttonRemoveAdresse_Click(object sender, EventArgs e)
   {
      var item = this.listBoxAdressen.SelectedItem as Adresse;
      if(item is null)
      {
         //Coudnt Remove
         return;
      }

      this._adressen.Remove(item);
      this.listBoxAdressen.Items.RemoveAt(this.listBoxAdressen.SelectedIndex);
   }

   #endregion
}
