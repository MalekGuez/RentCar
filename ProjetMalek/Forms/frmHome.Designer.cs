namespace ProjetMalek.Forms
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panelHome = new System.Windows.Forms.Panel();
            this.pctboxHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.pctboxHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(768, 461);
            this.panelHome.TabIndex = 1;
            // 
            // pctboxHome
            // 
            this.pctboxHome.BackColor = System.Drawing.Color.Transparent;
            this.pctboxHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctboxHome.Image = ((System.Drawing.Image)(resources.GetObject("pctboxHome.Image")));
            this.pctboxHome.Location = new System.Drawing.Point(0, 0);
            this.pctboxHome.Name = "pctboxHome";
            this.pctboxHome.Size = new System.Drawing.Size(768, 461);
            this.pctboxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctboxHome.TabIndex = 0;
            this.pctboxHome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENUE CHEZ RENT CAR !";
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.panelHome);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pctboxHome;
        private System.Windows.Forms.Label label1;
    }
}