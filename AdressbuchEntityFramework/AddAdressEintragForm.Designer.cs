namespace AdressbuchEntityFramework
{
   partial class AddAdressEintragForm
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
         cancelButton = new Button();
         saveButton = new Button();
         labelName = new Label();
         textBoxName = new TextBox();
         labelGeburtstag = new Label();
         geburtstagDatePicker = new DateTimePicker();
         textBoxTelNr = new TextBox();
         labelTelNummer = new Label();
         labelAdressen = new Label();
         buttonAddAdresse = new Button();
         buttonRemoveAdresse = new Button();
         listBoxAdressen = new ListBox();
         SuspendLayout();
         // 
         // cancelButton
         // 
         cancelButton.Location = new Point(302, 213);
         cancelButton.Name = "cancelButton";
         cancelButton.Size = new Size(75, 23);
         cancelButton.TabIndex = 0;
         cancelButton.Text = "Abbrechen";
         cancelButton.UseVisualStyleBackColor = true;
         cancelButton.Click += cancelButton_Click;
         // 
         // saveButton
         // 
         saveButton.Location = new Point(383, 213);
         saveButton.Name = "saveButton";
         saveButton.Size = new Size(75, 23);
         saveButton.TabIndex = 1;
         saveButton.Text = "Speichern";
         saveButton.UseVisualStyleBackColor = true;
         saveButton.Click += saveButton_Click;
         // 
         // labelName
         // 
         labelName.AutoSize = true;
         labelName.Location = new Point(12, 12);
         labelName.Name = "labelName";
         labelName.Size = new Size(45, 15);
         labelName.TabIndex = 2;
         labelName.Text = "Name: ";
         // 
         // textBoxName
         // 
         textBoxName.Location = new Point(91, 9);
         textBoxName.Name = "textBoxName";
         textBoxName.Size = new Size(100, 23);
         textBoxName.TabIndex = 3;
         // 
         // labelGeburtstag
         // 
         labelGeburtstag.AutoSize = true;
         labelGeburtstag.Location = new Point(12, 44);
         labelGeburtstag.Name = "labelGeburtstag";
         labelGeburtstag.Size = new Size(68, 15);
         labelGeburtstag.TabIndex = 4;
         labelGeburtstag.Text = "Geburtstag:";
         // 
         // geburtstagDatePicker
         // 
         geburtstagDatePicker.Location = new Point(91, 38);
         geburtstagDatePicker.Name = "geburtstagDatePicker";
         geburtstagDatePicker.Size = new Size(200, 23);
         geburtstagDatePicker.TabIndex = 5;
         // 
         // textBoxTelNr
         // 
         textBoxTelNr.Location = new Point(91, 67);
         textBoxTelNr.Name = "textBoxTelNr";
         textBoxTelNr.Size = new Size(100, 23);
         textBoxTelNr.TabIndex = 6;
         // 
         // labelTelNummer
         // 
         labelTelNummer.AutoSize = true;
         labelTelNummer.Location = new Point(12, 70);
         labelTelNummer.Name = "labelTelNummer";
         labelTelNummer.Size = new Size(62, 15);
         labelTelNummer.TabIndex = 7;
         labelTelNummer.Text = "Telefonnr.:";
         // 
         // labelAdressen
         // 
         labelAdressen.AutoSize = true;
         labelAdressen.Location = new Point(12, 98);
         labelAdressen.Name = "labelAdressen";
         labelAdressen.Size = new Size(58, 15);
         labelAdressen.TabIndex = 8;
         labelAdressen.Text = "Adressen:";
         // 
         // buttonAddAdresse
         // 
         buttonAddAdresse.Font = new Font("Microsoft Sans Serif", 8.25F);
         buttonAddAdresse.Location = new Point(302, 98);
         buttonAddAdresse.Name = "buttonAddAdresse";
         buttonAddAdresse.Size = new Size(75, 23);
         buttonAddAdresse.TabIndex = 11;
         buttonAddAdresse.Text = "Hinzufügen";
         buttonAddAdresse.UseVisualStyleBackColor = true;
         buttonAddAdresse.Click += buttonAddAdresse_Click;
         // 
         // buttonRemoveAdresse
         // 
         buttonRemoveAdresse.Location = new Point(302, 127);
         buttonRemoveAdresse.Name = "buttonRemoveAdresse";
         buttonRemoveAdresse.Size = new Size(75, 23);
         buttonRemoveAdresse.TabIndex = 12;
         buttonRemoveAdresse.Text = "Entfernen";
         buttonRemoveAdresse.UseVisualStyleBackColor = true;
         buttonRemoveAdresse.Click += buttonRemoveAdresse_Click;
         // 
         // listBoxAdressen
         // 
         listBoxAdressen.FormattingEnabled = true;
         listBoxAdressen.ItemHeight = 15;
         listBoxAdressen.Location = new Point(91, 96);
         listBoxAdressen.Name = "listBoxAdressen";
         listBoxAdressen.Size = new Size(205, 139);
         listBoxAdressen.TabIndex = 13;
         // 
         // AddAdressEintragForm
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(470, 248);
         Controls.Add(listBoxAdressen);
         Controls.Add(buttonRemoveAdresse);
         Controls.Add(buttonAddAdresse);
         Controls.Add(labelAdressen);
         Controls.Add(labelTelNummer);
         Controls.Add(textBoxTelNr);
         Controls.Add(geburtstagDatePicker);
         Controls.Add(labelGeburtstag);
         Controls.Add(textBoxName);
         Controls.Add(labelName);
         Controls.Add(saveButton);
         Controls.Add(cancelButton);
         Name = "AddAdressEintragForm";
         Text = "AddAdressForm";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button cancelButton;
      private Button saveButton;
      private Label labelName;
      private TextBox textBoxName;
      private Label labelGeburtstag;
      private DateTimePicker geburtstagDatePicker;
      private TextBox textBoxTelNr;
      private Label labelTelNummer;
      private Label labelAdressen;
      private Button buttonAddAdresse;
      private Button buttonRemoveAdresse;
      private ListBox listBoxAdressen;
   }
}