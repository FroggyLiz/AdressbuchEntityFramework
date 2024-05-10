using AdressbuchEntityFramework.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressbuchEntityFramework
{
   public partial class AddAdressEintragForm : Form
   {
      public AdressEintrag? Eintrag;
      public HashSet<Adresse> Adressen = new();

      public AddAdressEintragForm()
      {
         InitializeComponent();
      }

      private void saveButton_Click(object sender, EventArgs e)
      {
         this.Eintrag = new ();
         this.Eintrag.Geburtstag = this.geburtstagDatePicker.Value;
         this.Eintrag.TelefonNummer = this.textBoxTelNr.Text;
         this.Eintrag.Name = this.textBoxName.Text;
         this.Eintrag.Adressen = this.Adressen;

         this.Close();
      }

      private void cancelButton_Click(object sender, EventArgs e)
      {
         this.Eintrag = null;
         this.Close();
      }

      private void buttonAddAdresse_Click(object sender, EventArgs e)
      {
         using var addAdresseForm = new AddAdresseForm();
         addAdresseForm.ShowDialog();
         if(addAdresseForm.Adresse is null)
         {
            //Dont Add
            return;
         }

         this.Adressen.Add(addAdresseForm.Adresse);
         this.listBoxAdressen.Items.Add(addAdresseForm.Adresse);
      }

      private void buttonRemoveAdresse_Click(object sender, EventArgs e)
      {
         var item = this.listBoxAdressen.SelectedItem as Adresse;
         this.Adressen.Remove(item);
         this.listBoxAdressen.Items.RemoveAt(this.listBoxAdressen.SelectedIndex);
      }
   }
}
