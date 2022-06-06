namespace ProjetMalek.Forms
{
    partial class frmProfile
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstReserv = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(165, 164);
            this.lblName.MinimumSize = new System.Drawing.Size(130, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 30);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "                             ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(165, 224);
            this.lblSurname.MinimumSize = new System.Drawing.Size(130, 30);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(130, 30);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "                             ";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Prénom";
            // 
            // lstReserv
            // 
            this.lstReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstReserv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstReserv.ForeColor = System.Drawing.Color.White;
            this.lstReserv.FormattingEnabled = true;
            this.lstReserv.ItemHeight = 21;
            this.lstReserv.Location = new System.Drawing.Point(404, 152);
            this.lstReserv.Name = "lstReserv";
            this.lstReserv.Size = new System.Drawing.Size(305, 210);
            this.lstReserv.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre total \r\nde réservations";
            // 
            // lblDuration
            // 
            this.lblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(225, 289);
            this.lblDuration.MinimumSize = new System.Drawing.Size(70, 30);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(70, 30);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "                             ";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(611, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Historique";
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReserv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstReserv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label6;
    }
}