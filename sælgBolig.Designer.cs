
namespace SemesterProjekt2021
{
    partial class sælgBolig
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.solgteDato = new System.Windows.Forms.DateTimePicker();
            this.indtastSolgtePris = new System.Windows.Forms.TextBox();
            this.indTastKøberId = new System.Windows.Forms.TextBox();
            this.sælgBoligButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast køber ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indtast solgte pris:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dato: ";
            // 
            // solgteDato
            // 
            this.solgteDato.Location = new System.Drawing.Point(261, 189);
            this.solgteDato.Name = "solgteDato";
            this.solgteDato.Size = new System.Drawing.Size(250, 27);
            this.solgteDato.TabIndex = 3;
            // 
            // indtastSolgtePris
            // 
            this.indtastSolgtePris.Location = new System.Drawing.Point(261, 128);
            this.indtastSolgtePris.Name = "indtastSolgtePris";
            this.indtastSolgtePris.Size = new System.Drawing.Size(125, 27);
            this.indtastSolgtePris.TabIndex = 4;
            this.indtastSolgtePris.TextChanged += new System.EventHandler(this.indtastSolgtePris_TextChanged);
            // 
            // indTastKøberId
            // 
            this.indTastKøberId.Location = new System.Drawing.Point(261, 63);
            this.indTastKøberId.Name = "indTastKøberId";
            this.indTastKøberId.Size = new System.Drawing.Size(125, 27);
            this.indTastKøberId.TabIndex = 5;
            this.indTastKøberId.TextChanged += new System.EventHandler(this.indTastKøberId_TextChanged);
            // 
            // sælgBoligButton
            // 
            this.sælgBoligButton.Location = new System.Drawing.Point(261, 276);
            this.sælgBoligButton.Name = "sælgBoligButton";
            this.sælgBoligButton.Size = new System.Drawing.Size(94, 29);
            this.sælgBoligButton.TabIndex = 6;
            this.sælgBoligButton.Text = "Sælg";
            this.sælgBoligButton.UseVisualStyleBackColor = true;
            this.sælgBoligButton.Click += new System.EventHandler(this.sælgBoligButton_Click);
            // 
            // sælgBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sælgBoligButton);
            this.Controls.Add(this.indTastKøberId);
            this.Controls.Add(this.indtastSolgtePris);
            this.Controls.Add(this.solgteDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sælgBolig";
            this.Text = "sælgBolig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker solgteDato;
        private System.Windows.Forms.TextBox indtastSolgtePris;
        private System.Windows.Forms.TextBox indTastKøberId;
        private System.Windows.Forms.Button sælgBoligButton;
    }
}