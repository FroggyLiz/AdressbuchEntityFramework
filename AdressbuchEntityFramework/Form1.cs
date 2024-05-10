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

      var element = await SearchAdressEintrag(search, cts.Token);
      this.ShowElement(element);
   }

   private async Task<AdressEintrag?> SearchAdressEintrag(string search, CancellationToken token)
   {
      var context = new AppDbContext();
      return await context.AdressEinträge.FirstOrDefaultAsync(x => EF.Functions.Like(x.Name, search), token);
   }

   private void cancelSearchButton_Click(object sender, EventArgs e)
   {
      cts.Cancel();
   }

   private void ShowElement(AdressEintrag eintrag)
   {
      this.nameLabel.Text = eintrag.Name;
      this.geburtstagLabel.Text = eintrag.Geburtstag.ToShortDateString();
      this.telefonnrLabel.Text = eintrag.TelefonNummer;
      this.adressenLabel.Text = ComputeAdressesToString(eintrag.Adressen);
   }

   private string ComputeAdressesToString(IEnumerable<Adressen> adressen)
   {
      return string.Empty;
   }
}
