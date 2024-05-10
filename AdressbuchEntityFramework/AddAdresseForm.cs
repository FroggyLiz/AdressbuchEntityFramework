using AdressbuchEntityFramework.Model.Entities;

namespace AdressbuchEntityFramework;

internal partial class AddAdresseForm : Form
{
   #region Variables

   internal Adresse? Adresse;

   #endregion

   #region Constructor

   /// <summary>
   /// Constructor that Initializes this Component
   /// </summary>
   internal AddAdresseForm()
   {
      InitializeComponent();
   }

   #endregion

   #region Event-Methods

   /// <summary>
   /// When the save Button is Clicked, Add all Values to the public Object
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void saveButton_Click(object sender, EventArgs e)
   {
      this.Adresse = new();
      this.Adresse.Stadt = this.textBoxStadt.Text;
      this.Adresse.Postleitzahl = this.textBoxPlz.Text;
      this.Adresse.Hausnummer = this.textBoxHausnr.Text;
      this.Adresse.Straße = this.textBoxStraße.Text;

      this.Close();
   }

   /// <summary>
   /// When the Cancel Button is clicked, set the Object to null
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
   private void cancelButton_Click(object sender, EventArgs e)
   {
      this.Adresse = null;
      this.Close();
   }

   #endregion
}
