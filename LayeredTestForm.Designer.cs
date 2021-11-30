namespace SemesterProjekt2021
{
    partial class LayeredTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayeredTestForm));
            this.panelheader = new System.Windows.Forms.Panel();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseProgramButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelside = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PersonButton = new System.Windows.Forms.Button();
            this.BoligButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panelheader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelside.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
            this.panelheader.Controls.Add(this.LocationLabel);
            this.panelheader.Controls.Add(this.panel2);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(810, 29);
            this.panelheader.TabIndex = 0;
            this.panelheader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelheader_Paint);
            this.panelheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseDown);
            this.panelheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseMove);
            this.panelheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseUp);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LocationLabel.Location = new System.Drawing.Point(3, 4);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(62, 25);
            this.LocationLabel.TabIndex = 5;
            this.LocationLabel.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CloseProgramButton);
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Controls.Add(this.MaximizeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(743, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 29);
            this.panel2.TabIndex = 4;
            // 
            // CloseProgramButton
            // 
            this.CloseProgramButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
            this.CloseProgramButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseProgramButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CloseProgramButton.FlatAppearance.BorderSize = 0;
            this.CloseProgramButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CloseProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseProgramButton.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseProgramButton.ForeColor = System.Drawing.Color.White;
            this.CloseProgramButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseProgramButton.Location = new System.Drawing.Point(41, 3);
            this.CloseProgramButton.Name = "CloseProgramButton";
            this.CloseProgramButton.Size = new System.Drawing.Size(26, 26);
            this.CloseProgramButton.TabIndex = 1;
            this.CloseProgramButton.Text = "X";
            this.CloseProgramButton.UseVisualStyleBackColor = false;
            this.CloseProgramButton.Click += new System.EventHandler(this.CloseProgramButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimizeButton.Location = new System.Drawing.Point(-8, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(26, 26);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeButton.ForeColor = System.Drawing.Color.White;
            this.MaximizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaximizeButton.Location = new System.Drawing.Point(15, 3);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(26, 26);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.Text = "▭";
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Location = new System.Drawing.Point(158, 29);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(652, 449);
            this.MainPanel.TabIndex = 2;
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.panelside.Controls.Add(this.SearchButton);
            this.panelside.Controls.Add(this.panel1);
            this.panelside.Controls.Add(this.PersonButton);
            this.panelside.Controls.Add(this.BoligButton);
            this.panelside.Controls.Add(this.HomeButton);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 29);
            this.panelside.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(163, 449);
            this.panelside.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(3, 195);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(157, 33);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Søg";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(204)))), ((int)(((byte)(215)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 79);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PersonButton
            // 
            this.PersonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.PersonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.PersonButton.FlatAppearance.BorderSize = 0;
            this.PersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.PersonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonButton.Location = new System.Drawing.Point(3, 157);
            this.PersonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonButton.Name = "PersonButton";
            this.PersonButton.Size = new System.Drawing.Size(157, 33);
            this.PersonButton.TabIndex = 1;
            this.PersonButton.Text = "Person";
            this.PersonButton.UseVisualStyleBackColor = false;
            this.PersonButton.Click += new System.EventHandler(this.PersonButton_Click);
            // 
            // BoligButton
            // 
            this.BoligButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.BoligButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoligButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BoligButton.FlatAppearance.BorderSize = 0;
            this.BoligButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoligButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BoligButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.BoligButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BoligButton.Location = new System.Drawing.Point(3, 120);
            this.BoligButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoligButton.Name = "BoligButton";
            this.BoligButton.Size = new System.Drawing.Size(157, 33);
            this.BoligButton.TabIndex = 2;
            this.BoligButton.Text = "Bolig";
            this.BoligButton.UseVisualStyleBackColor = false;
            this.BoligButton.Click += new System.EventHandler(this.BoligButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(3, 83);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(157, 33);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LayeredTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 478);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LayeredTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCTestForm";
            this.Load += new System.EventHandler(this.UCTestForm_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelside.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PersonButton;
        private System.Windows.Forms.Button BoligButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button CloseProgramButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label LocationLabel;
    }
}