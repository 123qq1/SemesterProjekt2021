﻿
namespace SemesterProjekt2021
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrintAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintSome = new System.Windows.Forms.Button();
            this.byInputTilSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printMellemDatoer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inputBeløbTilWeirdSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Print alle huse til txt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrintAll
            // 
            this.PrintAll.Location = new System.Drawing.Point(88, 78);
            this.PrintAll.Name = "PrintAll";
            this.PrintAll.Size = new System.Drawing.Size(94, 29);
            this.PrintAll.TabIndex = 1;
            this.PrintAll.Text = "Print";
            this.PrintAll.UseVisualStyleBackColor = true;
            this.PrintAll.Click += new System.EventHandler(this.PrintAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Udskriv alle boliger fra by med tilhørende sælger";
            // 
            // PrintSome
            // 
            this.PrintSome.Location = new System.Drawing.Point(327, 181);
            this.PrintSome.Name = "PrintSome";
            this.PrintSome.Size = new System.Drawing.Size(94, 29);
            this.PrintSome.TabIndex = 5;
            this.PrintSome.Text = "Print";
            this.PrintSome.UseVisualStyleBackColor = true;
            this.PrintSome.Click += new System.EventHandler(this.PrintSome_Click);
            // 
            // byInputTilSearch
            // 
            this.byInputTilSearch.Location = new System.Drawing.Point(175, 183);
            this.byInputTilSearch.Name = "byInputTilSearch";
            this.byInputTilSearch.Size = new System.Drawing.Size(125, 27);
            this.byInputTilSearch.TabIndex = 6;
            this.byInputTilSearch.TextChanged += new System.EventHandler(this.byInputTilSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Indtast by: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Udskriv alle solgte boliger mellem de 2 valgte datoer som er større end valgte be" +
    "løb";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(171, 332);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date 2";
            // 
            // printMellemDatoer
            // 
            this.printMellemDatoer.Location = new System.Drawing.Point(410, 379);
            this.printMellemDatoer.Name = "printMellemDatoer";
            this.printMellemDatoer.Size = new System.Drawing.Size(94, 29);
            this.printMellemDatoer.TabIndex = 13;
            this.printMellemDatoer.Text = "Print";
            this.printMellemDatoer.UseVisualStyleBackColor = true;
            this.printMellemDatoer.Click += new System.EventHandler(this.printMellemDatoer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Indtast valgte beløb";
            // 
            // inputBeløbTilWeirdSearch
            // 
            this.inputBeløbTilWeirdSearch.Location = new System.Drawing.Point(261, 383);
            this.inputBeløbTilWeirdSearch.Name = "inputBeløbTilWeirdSearch";
            this.inputBeløbTilWeirdSearch.Size = new System.Drawing.Size(125, 27);
            this.inputBeløbTilWeirdSearch.TabIndex = 15;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputBeløbTilWeirdSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.printMellemDatoer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.byInputTilSearch);
            this.Controls.Add(this.PrintSome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrintAll);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrintSome;
        private System.Windows.Forms.TextBox byInputTilSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button printMellemDatoer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputBeløbTilWeirdSearch;
    }
}