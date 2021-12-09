
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Print alle huse til txt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrintAll
            // 
            this.PrintAll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintAll.Location = new System.Drawing.Point(7, 5);
            this.PrintAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintAll.Name = "PrintAll";
            this.PrintAll.Size = new System.Drawing.Size(146, 35);
            this.PrintAll.TabIndex = 1;
            this.PrintAll.Text = "Print";
            this.PrintAll.UseVisualStyleBackColor = true;
            this.PrintAll.Click += new System.EventHandler(this.PrintAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Udskriv alle boliger fra by med tilhørende sælger";
            // 
            // PrintSome
            // 
            this.PrintSome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintSome.Location = new System.Drawing.Point(277, 137);
            this.PrintSome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintSome.Name = "PrintSome";
            this.PrintSome.Size = new System.Drawing.Size(82, 23);
            this.PrintSome.TabIndex = 6;
            this.PrintSome.Text = "Print";
            this.PrintSome.UseVisualStyleBackColor = true;
            this.PrintSome.Click += new System.EventHandler(this.PrintSome_Click);
            // 
            // byInputTilSearch
            // 
            this.byInputTilSearch.Location = new System.Drawing.Point(161, 137);
            this.byInputTilSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.byInputTilSearch.Name = "byInputTilSearch";
            this.byInputTilSearch.Size = new System.Drawing.Size(110, 23);
            this.byInputTilSearch.TabIndex = 5;
            this.byInputTilSearch.TextChanged += new System.EventHandler(this.byInputTilSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Indtast by: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 208);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Udskriv alle solgte boliger mellem de 2 valgte datoer som er større end valgte be" +
    "løb";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(150, 249);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(70, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date 2";
            // 
            // printMellemDatoer
            // 
            this.printMellemDatoer.Location = new System.Drawing.Point(338, 287);
            this.printMellemDatoer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printMellemDatoer.Name = "printMellemDatoer";
            this.printMellemDatoer.Size = new System.Drawing.Size(82, 23);
            this.printMellemDatoer.TabIndex = 16;
            this.printMellemDatoer.Text = "Print";
            this.printMellemDatoer.UseVisualStyleBackColor = true;
            this.printMellemDatoer.Click += new System.EventHandler(this.printMellemDatoer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(70, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Indtast valgte beløb";
            // 
            // inputBeløbTilWeirdSearch
            // 
            this.inputBeløbTilWeirdSearch.Location = new System.Drawing.Point(222, 287);
            this.inputBeløbTilWeirdSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBeløbTilWeirdSearch.Name = "inputBeløbTilWeirdSearch";
            this.inputBeløbTilWeirdSearch.Size = new System.Drawing.Size(110, 23);
            this.inputBeløbTilWeirdSearch.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.PrintAll);
            this.panel1.Location = new System.Drawing.Point(63, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 44);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.panel3.Location = new System.Drawing.Point(333, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 34);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.panel2.Location = new System.Drawing.Point(273, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 34);
            this.panel2.TabIndex = 20;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}