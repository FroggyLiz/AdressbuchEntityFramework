using AdressbuchEntityFramework.Model;
using AdressbuchEntityFramework.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdressbuchEntityFramework;

public partial class Form1 : Form
{
   CancellationTokenSource cts;

   public Form1()
   {
      InitializeComponent();
      cts = new CancellationTokenSource();
   }

   private async void searchButton_Click(object sender, EventArgs e)
   {
      var search = this.searchtermTextBox.Text;

      _ = Task.Run(async () =>
      {
         cts = new CancellationTokenSource();
         var element = await SearchAdressEintrag(search, cts.Token);
         if (element is null)
         {
            MessageBox.Show($"Unter '{search}' wird kein Eintrag gefunden!",
               "Kein Eintrag gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
         }

         this.ShowElement(element);
      });
   }

   private async Task<AdressEintrag?> SearchAdressEintrag(string search, CancellationToken token)
   {
      var context = new AppDbContext();

      return await context.AdressEinträge.Include(x => x.Adressen)
         .FirstOrDefaultAsync(x => EF.Functions.Like(x.Name, search), token);
   }

   private async Task AddAdressEintrag(AdressEintrag eintrag)
   {
      var context = new AppDbContext();
      await context.AdressEinträge.AddAsync(eintrag);
      await context.SaveChangesAsync();
   }

   private void cancelSearchButton_Click(object sender, EventArgs e)
   {
      cts.Cancel();
   }

   private void ShowElement(AdressEintrag eintrag)
   {
      //Invoke to the UI Thread
      this.nameLabel.BeginInvoke((MethodInvoker)delegate () { this.nameLabel.Text = eintrag.Name; ; });
      this.geburtstagLabel.BeginInvoke((MethodInvoker)delegate () { this.geburtstagLabel.Text = eintrag.Geburtstag.ToShortDateString(); ; });
      this.telefonnrLabel.BeginInvoke((MethodInvoker)delegate () { this.telefonnrLabel.Text = eintrag.TelefonNummer; ; });
      this.adressenLabel.BeginInvoke((MethodInvoker)delegate () { this.adressenLabel.Text = ComputeAdressesToString(eintrag.Adressen); ; });
   }

   private string ComputeAdressesToString(IEnumerable<Adresse> adressen)
   {
      return string.Join("\n", adressen);
   }

   private async void neuEintragButton_Click(object sender, EventArgs e)
   {
      using var addEintragForm = new AddAdressEintragForm();
      addEintragForm.ShowDialog();
      if(addEintragForm.Eintrag is null)
      {
         //Dont save
         return;
      }

      await AddAdressEintrag(addEintragForm.Eintrag);
   }
}
