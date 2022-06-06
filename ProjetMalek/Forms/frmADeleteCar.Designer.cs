namespace ProjetMalek.Forms
{
    partial class frmADeleteCar
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
            this.lblValid = new System.Windows.Forms.Label();
            this.btnAAddCar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.lblReserved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblValid.Location = new System.Drawing.Point(217, 383);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(356, 21);
            this.lblValid.TabIndex = 32;
            this.lblValid.Text = "Le véhicule a été supprimé avec succès !";
            this.lblValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValid.Visible = false;
            // 
            // btnAAddCar
            // 
            this.btnAAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAAddCar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAAddCar.FlatAppearance.BorderSize = 2;
            this.btnAAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAAddCar.Location = new System.Drawing.Point(504, 194);
            this.btnAAddCar.Name = "btnAAddCar";
            this.btnAAddCar.Size = new System.Drawing.Size(150, 46);
            this.btnAAddCar.TabIndex = 35;
            this.btnAAddCar.Text = "Supprimer";
            this.btnAAddCar.UseVisualStyleBackColor = false;
            this.btnAAddCar.Click += new System.EventHandler(this.btnAAddCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Catalogue des voitures :";
            // 
            // lstCars
            // 
            this.lstCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCars.ForeColor = System.Drawing.Color.White;
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 21;
            this.lstCars.Location = new System.Drawing.Point(38, 110);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(335, 210);
            this.lstCars.TabIndex = 36;
            // 
            // lblReserved
            // 
            this.lblReserved.AutoSize = true;
            this.lblReserved.BackColor = System.Drawing.Color.Transparent;
            this.lblReserved.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserved.ForeColor = System.Drawing.Color.IndianRed;
            this.lblReserved.Location = new System.Drawing.Point(181, 382);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(447, 44);
            this.lblReserved.TabIndex = 38;
            this.lblReserved.Text = "Le modèle de véhicule est en cours de location.\r\nIl ne peut être supprimé.\r\n";
            this.lblReserved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReserved.Visible = false;
            // 
            // frmADeleteCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.lblReserved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.btnAAddCar);
            this.Controls.Add(this.lblValid);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmADeleteCar";
            this.Text = "frmADeleteCar";
            this.Load += new System.EventHandler(this.frmADeleteCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Button btnAAddCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Label lblReserved;
    }
}