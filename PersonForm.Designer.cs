﻿namespace SemesterProjekt2021
{
    partial class PersonForm
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
            this.DeletePersonButton = new System.Windows.Forms.Button();
            this.UpdatePersonButton = new System.Windows.Forms.Button();
            this.ReadPersonButton = new System.Windows.Forms.Button();
            this.CreatePersonButton = new System.Windows.Forms.Button();
            this.AddresseTextBox = new System.Windows.Forms.TextBox();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TelefonNummerLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CPRLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CPRTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessageboxClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeletePersonButton
            // 
            this.DeletePersonButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletePersonButton.Location = new System.Drawing.Point(468, 309);
            this.DeletePersonButton.Name = "DeletePersonButton";
            this.DeletePersonButton.Size = new System.Drawing.Size(115, 67);
            this.DeletePersonButton.TabIndex = 53;
            this.DeletePersonButton.Text = "Slet";
            this.DeletePersonButton.UseVisualStyleBackColor = true;
            this.DeletePersonButton.Click += new System.EventHandler(this.DeletePersonButton_Click);
            // 
            // UpdatePersonButton
            // 
            this.UpdatePersonButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdatePersonButton.Location = new System.Drawing.Point(347, 309);
            this.UpdatePersonButton.Name = "UpdatePersonButton";
            this.UpdatePersonButton.Size = new System.Drawing.Size(115, 67);
            this.UpdatePersonButton.TabIndex = 51;
            this.UpdatePersonButton.Text = "Opdater";
            this.UpdatePersonButton.UseVisualStyleBackColor = true;
            this.UpdatePersonButton.Click += new System.EventHandler(this.UpdatePersonButton_Click);
            // 
            // ReadPersonButton
            // 
            this.ReadPersonButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadPersonButton.Location = new System.Drawing.Point(468, 236);
            this.ReadPersonButton.Name = "ReadPersonButton";
            this.ReadPersonButton.Size = new System.Drawing.Size(115, 67);
            this.ReadPersonButton.TabIndex = 50;
            this.ReadPersonButton.Text = "Find";
            this.ReadPersonButton.UseVisualStyleBackColor = true;
            this.ReadPersonButton.Click += new System.EventHandler(this.ReadHomeButton_Click);
            // 
            // CreatePersonButton
            // 
            this.CreatePersonButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePersonButton.Location = new System.Drawing.Point(347, 236);
            this.CreatePersonButton.Name = "CreatePersonButton";
            this.CreatePersonButton.Size = new System.Drawing.Size(115, 67);
            this.CreatePersonButton.TabIndex = 49;
            this.CreatePersonButton.Text = "Opret";
            this.CreatePersonButton.UseVisualStyleBackColor = true;
            this.CreatePersonButton.Click += new System.EventHandler(this.CreateHomeButton_Click);
            // 
            // AddresseTextBox
            // 
            this.AddresseTextBox.Location = new System.Drawing.Point(359, 177);
            this.AddresseTextBox.Name = "AddresseTextBox";
            this.AddresseTextBox.Size = new System.Drawing.Size(216, 23);
            this.AddresseTextBox.TabIndex = 47;
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(359, 123);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(216, 23);
            this.ZipTextBox.TabIndex = 46;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(359, 69);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(216, 23);
            this.CityTextBox.TabIndex = 45;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Location = new System.Drawing.Point(45, 339);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(216, 23);
            this.LNameTextBox.TabIndex = 43;
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Location = new System.Drawing.Point(45, 285);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(216, 23);
            this.FNameTextBox.TabIndex = 42;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(45, 231);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(216, 23);
            this.PhoneNumberTextBox.TabIndex = 41;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(45, 69);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(216, 23);
            this.IDTextBox.TabIndex = 38;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.Location = new System.Drawing.Point(359, 149);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 21);
            this.AddressLabel.TabIndex = 36;
            this.AddressLabel.Text = "Adresse";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipLabel.Location = new System.Drawing.Point(359, 95);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(103, 21);
            this.ZipLabel.TabIndex = 35;
            this.ZipLabel.Text = "Post nummer";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityLabel.Location = new System.Drawing.Point(359, 41);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 21);
            this.CityLabel.TabIndex = 34;
            this.CityLabel.Text = "By";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(45, 311);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 21);
            this.LastNameLabel.TabIndex = 32;
            this.LastNameLabel.Text = "Efternavn";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(46, 257);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(67, 21);
            this.FirstNameLabel.TabIndex = 31;
            this.FirstNameLabel.Text = "Fornavn";
            // 
            // TelefonNummerLabel
            // 
            this.TelefonNummerLabel.AutoSize = true;
            this.TelefonNummerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelefonNummerLabel.Location = new System.Drawing.Point(46, 203);
            this.TelefonNummerLabel.Name = "TelefonNummerLabel";
            this.TelefonNummerLabel.Size = new System.Drawing.Size(123, 21);
            this.TelefonNummerLabel.TabIndex = 30;
            this.TelefonNummerLabel.Text = "Telefon nummer";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(46, 149);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 21);
            this.EmailLabel.TabIndex = 29;
            this.EmailLabel.Text = "Email";
            // 
            // CPRLabel
            // 
            this.CPRLabel.AutoSize = true;
            this.CPRLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPRLabel.Location = new System.Drawing.Point(46, 95);
            this.CPRLabel.Name = "CPRLabel";
            this.CPRLabel.Size = new System.Drawing.Size(39, 21);
            this.CPRLabel.TabIndex = 28;
            this.CPRLabel.Text = "CPR";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(46, 41);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 21);
            this.IDLabel.TabIndex = 27;
            this.IDLabel.Text = "ID";
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Location = new System.Drawing.Point(45, 123);
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.Size = new System.Drawing.Size(216, 23);
            this.CPRTextBox.TabIndex = 54;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(45, 177);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(216, 23);
            this.EmailTextBox.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.panel1.Location = new System.Drawing.Point(340, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 154);
            this.panel1.TabIndex = 56;
            // 
            // MessageboxClearButton
            // 
            this.MessageboxClearButton.Location = new System.Drawing.Point(46, 369);
            this.MessageboxClearButton.Name = "MessageboxClearButton";
            this.MessageboxClearButton.Size = new System.Drawing.Size(102, 23);
            this.MessageboxClearButton.TabIndex = 57;
            this.MessageboxClearButton.Text = "Slet alt tekst";
            this.MessageboxClearButton.UseVisualStyleBackColor = true;
            this.MessageboxClearButton.Click += new System.EventHandler(this.MessageboxClearButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(698, 492);
            this.Controls.Add(this.MessageboxClearButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.CPRTextBox);
            this.Controls.Add(this.DeletePersonButton);
            this.Controls.Add(this.UpdatePersonButton);
            this.Controls.Add(this.ReadPersonButton);
            this.Controls.Add(this.CreatePersonButton);
            this.Controls.Add(this.AddresseTextBox);
            this.Controls.Add(this.ZipTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.FNameTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.TelefonNummerLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CPRLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeletePersonButton;
        private System.Windows.Forms.Button UpdatePersonButton;
        private System.Windows.Forms.Button ReadPersonButton;
        private System.Windows.Forms.Button CreatePersonButton;
        private System.Windows.Forms.TextBox AddresseTextBox;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label TelefonNummerLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CPRLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox CPRTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MessageboxClearButton;
    }
}