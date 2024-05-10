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
   public partial class AddAdresseForm : Form
   {
      public Adresse? Adresse;

      public AddAdresseForm()
      {
         InitializeComponent();
      }

      private void saveButton_Click(object sender, EventArgs e)
      {
         this.Adresse = new();
         this.Adresse.Stadt = this.textBoxStadt.Text;
         this.Adresse.Postleitzahl = this.textBoxPlz.Text;
         this.Adresse.Hausnummer = this.textBoxHausnr.Text;
         this.Adresse.Straße = this.textBoxStraße.Text;

         this.Close();
      }

      private void cancelButton_Click(object sender, EventArgs e)
      {
         this.Adresse = null;
         this.Close();
      }
   }
}
