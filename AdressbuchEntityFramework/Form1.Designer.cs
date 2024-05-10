namespace AdressbuchEntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         searchtermTextBox = new TextBox();
         searchButton = new Button();
         cancelSearchButton = new Button();
         tableLayoutPanel1 = new TableLayoutPanel();
         label1 = new Label();
         label3 = new Label();
         nameLabel = new Label();
         label4 = new Label();
         telefonnrLabel = new Label();
         geburtstagLabel = new Label();
         adressenLabel = new Label();
         label2 = new Label();
         neuEintragButton = new Button();
         tableLayoutPanel1.SuspendLayout();
         SuspendLayout();
         // 
         // searchtermTextBox
         // 
         searchtermTextBox.Location = new Point(12, 11);
         searchtermTextBox.Name = "searchtermTextBox";
         searchtermTextBox.Size = new Size(291, 23);
         searchtermTextBox.TabIndex = 0;
         // 
         // searchButton
         // 
         searchButton.Location = new Point(309, 10);
         searchButton.Name = "searchButton";
         searchButton.Size = new Size(75, 23);
         searchButton.TabIndex = 1;
         searchButton.Text = "Suchen";
         searchButton.UseVisualStyleBackColor = true;
         searchButton.Click += searchButton_Click;
         // 
         // cancelSearchButton
         // 
         cancelSearchButton.Location = new Point(390, 10);
         cancelSearchButton.Name = "cancelSearchButton";
         cancelSearchButton.Size = new Size(75, 23);
         cancelSearchButton.TabIndex = 2;
         cancelSearchButton.Text = "Abbrechen";
         cancelSearchButton.UseVisualStyleBackColor = true;
         cancelSearchButton.Click += cancelSearchButton_Click;
         // 
         // tableLayoutPanel1
         // 
         tableLayoutPanel1.ColumnCount = 2;
         tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
         tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
         tableLayoutPanel1.Controls.Add(label1, 0, 0);
         tableLayoutPanel1.Controls.Add(label3, 0, 2);
         tableLayoutPanel1.Controls.Add(nameLabel, 1, 0);
         tableLayoutPanel1.Controls.Add(label4, 0, 1);
         tableLayoutPanel1.Controls.Add(telefonnrLabel, 1, 2);
         tableLayoutPanel1.Controls.Add(geburtstagLabel, 1, 1);
         tableLayoutPanel1.Controls.Add(adressenLabel, 1, 3);
         tableLayoutPanel1.Controls.Add(label2, 0, 3);
         tableLayoutPanel1.Location = new Point(14, 40);
         tableLayoutPanel1.Name = "tableLayoutPanel1";
         tableLayoutPanel1.RowCount = 4;
         tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
         tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
         tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
         tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
         tableLayoutPanel1.Size = new Size(289, 176);
         tableLayoutPanel1.TabIndex = 3;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(3, 0);
         label1.Name = "label1";
         label1.Size = new Size(39, 15);
         label1.TabIndex = 0;
         label1.Text = "Name";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(3, 40);
         label3.Name = "label3";
         label3.Size = new Size(59, 15);
         label3.TabIndex = 2;
         label3.Text = "Telefonnr.";
         // 
         // nameLabel
         // 
         nameLabel.AutoSize = true;
         nameLabel.Location = new Point(147, 0);
         nameLabel.Name = "nameLabel";
         nameLabel.Size = new Size(101, 15);
         nameLabel.TabIndex = 4;
         nameLabel.Text = "Max Mustermann";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(3, 20);
         label4.Name = "label4";
         label4.Size = new Size(65, 15);
         label4.TabIndex = 3;
         label4.Text = "Geburtstag";
         // 
         // telefonnrLabel
         // 
         telefonnrLabel.AutoSize = true;
         telefonnrLabel.Location = new Point(147, 40);
         telefonnrLabel.Name = "telefonnrLabel";
         telefonnrLabel.Size = new Size(93, 15);
         telefonnrLabel.TabIndex = 6;
         telefonnrLabel.Text = "0251 / 20888 255";
         // 
         // geburtstagLabel
         // 
         geburtstagLabel.AutoSize = true;
         geburtstagLabel.Location = new Point(147, 20);
         geburtstagLabel.Name = "geburtstagLabel";
         geburtstagLabel.Size = new Size(61, 15);
         geburtstagLabel.TabIndex = 7;
         geburtstagLabel.Text = "01.01.2000";
         // 
         // adressenLabel
         // 
         adressenLabel.AutoSize = true;
         adressenLabel.Location = new Point(147, 60);
         adressenLabel.Name = "adressenLabel";
         adressenLabel.Size = new Size(111, 30);
         adressenLabel.TabIndex = 5;
         adressenLabel.Text = "Corrensstraße 80\r\nJohankrahneweg 23";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(3, 60);
         label2.Name = "label2";
         label2.Size = new Size(55, 15);
         label2.TabIndex = 1;
         label2.Text = "Adressen";
         // 
         // neuEintragButton
         // 
         neuEintragButton.Location = new Point(362, 222);
         neuEintragButton.Name = "neuEintragButton";
         neuEintragButton.Size = new Size(103, 23);
         neuEintragButton.TabIndex = 4;
         neuEintragButton.Text = "Neuer Eintrag";
         neuEintragButton.UseVisualStyleBackColor = true;
         neuEintragButton.Click += neuEintragButton_Click;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(470, 248);
         Controls.Add(neuEintragButton);
         Controls.Add(tableLayoutPanel1);
         Controls.Add(cancelSearchButton);
         Controls.Add(searchButton);
         Controls.Add(searchtermTextBox);
         Name = "Form1";
         Text = "Adressbuch";
         tableLayoutPanel1.ResumeLayout(false);
         tableLayoutPanel1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox searchtermTextBox;
        private Button searchButton;
        private Button cancelSearchButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label nameLabel;
        private Label adressenLabel;
        private Label telefonnrLabel;
        private Label geburtstagLabel;
        private Button neuEintragButton;
    }
}
