namespace AdressbuchEntityFramework
{
   partial class AddAdresseForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         saveButton = new Button();
         cancelButton = new Button();
         textBoxStraße = new TextBox();
         labelStraße = new Label();
         textBoxHausnr = new TextBox();
         labelHausNr = new Label();
         textBoxPlz = new TextBox();
         labelPlz = new Label();
         textBoxStadt = new TextBox();
         labelStadt = new Label();
         SuspendLayout();
         // 
         // saveButton
         // 
         saveButton.Location = new Point(122, 160);
         saveButton.Name = "saveButton";
         saveButton.Size = new Size(75, 23);
         saveButton.TabIndex = 3;
         saveButton.Text = "Speichern";
         saveButton.UseVisualStyleBackColor = true;
         saveButton.Click += saveButton_Click;
         // 
         // cancelButton
         // 
         cancelButton.Location = new Point(41, 160);
         cancelButton.Name = "cancelButton";
         cancelButton.Size = new Size(75, 23);
         cancelButton.TabIndex = 2;
         cancelButton.Text = "Abbrechen";
         cancelButton.UseVisualStyleBackColor = true;
         cancelButton.Click += cancelButton_Click;
         // 
         // textBoxStraße
         // 
         textBoxStraße.Location = new Point(91, 6);
         textBoxStraße.Name = "textBoxStraße";
         textBoxStraße.Size = new Size(100, 23);
         textBoxStraße.TabIndex = 5;
         // 
         // labelStraße
         // 
         labelStraße.AutoSize = true;
         labelStraße.Location = new Point(12, 9);
         labelStraße.Name = "labelStraße";
         labelStraße.Size = new Size(43, 15);
         labelStraße.TabIndex = 4;
         labelStraße.Text = "Straße:";
         // 
         // textBoxHausnr
         // 
         textBoxHausnr.Location = new Point(91, 35);
         textBoxHausnr.Name = "textBoxHausnr";
         textBoxHausnr.Size = new Size(100, 23);
         textBoxHausnr.TabIndex = 7;
         // 
         // labelHausNr
         // 
         labelHausNr.AutoSize = true;
         labelHausNr.Location = new Point(12, 38);
         labelHausNr.Name = "labelHausNr";
         labelHausNr.Size = new Size(51, 15);
         labelHausNr.TabIndex = 6;
         labelHausNr.Text = "Hausnr.:";
         // 
         // textBoxPlz
         // 
         textBoxPlz.Location = new Point(91, 64);
         textBoxPlz.Name = "textBoxPlz";
         textBoxPlz.Size = new Size(100, 23);
         textBoxPlz.TabIndex = 9;
         // 
         // labelPlz
         // 
         labelPlz.AutoSize = true;
         labelPlz.Location = new Point(12, 67);
         labelPlz.Name = "labelPlz";
         labelPlz.Size = new Size(70, 15);
         labelPlz.TabIndex = 8;
         labelPlz.Text = "Postleitzahl:";
         // 
         // textBoxStadt
         // 
         textBoxStadt.Location = new Point(91, 93);
         textBoxStadt.Name = "textBoxStadt";
         textBoxStadt.Size = new Size(100, 23);
         textBoxStadt.TabIndex = 11;
         // 
         // labelStadt
         // 
         labelStadt.AutoSize = true;
         labelStadt.Location = new Point(12, 96);
         labelStadt.Name = "labelStadt";
         labelStadt.Size = new Size(37, 15);
         labelStadt.TabIndex = 10;
         labelStadt.Text = "Stadt:";
         // 
         // AddAdresseForm
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(209, 195);
         Controls.Add(textBoxStadt);
         Controls.Add(labelStadt);
         Controls.Add(textBoxPlz);
         Controls.Add(labelPlz);
         Controls.Add(textBoxHausnr);
         Controls.Add(labelHausNr);
         Controls.Add(textBoxStraße);
         Controls.Add(labelStraße);
         Controls.Add(saveButton);
         Controls.Add(cancelButton);
         Name = "AddAdresseForm";
         Text = "AddAdresseForm";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button saveButton;
      private Button cancelButton;
      private TextBox textBoxStraße;
      private Label labelStraße;
      private TextBox textBoxHausnr;
      private Label labelHausNr;
      private TextBox textBoxPlz;
      private Label labelPlz;
      private TextBox textBoxStadt;
      private Label labelStadt;
   }
}