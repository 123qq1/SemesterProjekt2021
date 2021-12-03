namespace SemesterProjekt2021
{
    partial class HomeForm
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
            this.OverskriftLabel = new System.Windows.Forms.Label();
            this.ChristofferLabel = new System.Windows.Forms.Label();
            this.GlennLabel = new System.Windows.Forms.Label();
            this.JeppeLabel = new System.Windows.Forms.Label();
            this.OliverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OverskriftLabel
            // 
            this.OverskriftLabel.AutoSize = true;
            this.OverskriftLabel.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OverskriftLabel.Location = new System.Drawing.Point(62, 28);
            this.OverskriftLabel.Name = "OverskriftLabel";
            this.OverskriftLabel.Size = new System.Drawing.Size(491, 62);
            this.OverskriftLabel.TabIndex = 0;
            this.OverskriftLabel.Text = "Semester opgave 2021";
            // 
            // ChristofferLabel
            // 
            this.ChristofferLabel.AutoSize = true;
            this.ChristofferLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChristofferLabel.Location = new System.Drawing.Point(106, 117);
            this.ChristofferLabel.Name = "ChristofferLabel";
            this.ChristofferLabel.Size = new System.Drawing.Size(237, 46);
            this.ChristofferLabel.TabIndex = 1;
            this.ChristofferLabel.Text = "Christoffer Ott";
            // 
            // GlennLabel
            // 
            this.GlennLabel.AutoSize = true;
            this.GlennLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GlennLabel.Location = new System.Drawing.Point(106, 167);
            this.GlennLabel.Name = "GlennLabel";
            this.GlennLabel.Size = new System.Drawing.Size(219, 46);
            this.GlennLabel.TabIndex = 2;
            this.GlennLabel.Text = "Glenn Olesen";
            // 
            // JeppeLabel
            // 
            this.JeppeLabel.AutoSize = true;
            this.JeppeLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JeppeLabel.Location = new System.Drawing.Point(106, 217);
            this.JeppeLabel.Name = "JeppeLabel";
            this.JeppeLabel.Size = new System.Drawing.Size(289, 46);
            this.JeppeLabel.TabIndex = 3;
            this.JeppeLabel.Text = "Jeppe Bjerremand";
            // 
            // OliverLabel
            // 
            this.OliverLabel.AutoSize = true;
            this.OliverLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OliverLabel.Location = new System.Drawing.Point(106, 267);
            this.OliverLabel.Name = "OliverLabel";
            this.OliverLabel.Size = new System.Drawing.Size(236, 46);
            this.OliverLabel.TabIndex = 4;
            this.OliverLabel.Text = "Oliver Madsen";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 478);
            this.Controls.Add(this.OliverLabel);
            this.Controls.Add(this.JeppeLabel);
            this.Controls.Add(this.GlennLabel);
            this.Controls.Add(this.ChristofferLabel);
            this.Controls.Add(this.OverskriftLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OverskriftLabel;
        private System.Windows.Forms.Label ChristofferLabel;
        private System.Windows.Forms.Label GlennLabel;
        private System.Windows.Forms.Label JeppeLabel;
        private System.Windows.Forms.Label OliverLabel;
    }
}