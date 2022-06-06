namespace ProjetMalek.Forms
{
    partial class frmAAddCar
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
            this.lstCars = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAAddCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTexts = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.lstCars.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Catalogue des voitures :";
            // 
            // btnAAddCar
            // 
            this.btnAAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAAddCar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAAddCar.FlatAppearance.BorderSize = 2;
            this.btnAAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAAddCar.Location = new System.Drawing.Point(480, 357);
            this.btnAAddCar.Name = "btnAAddCar";
            this.btnAAddCar.Size = new System.Drawing.Size(150, 46);
            this.btnAAddCar.TabIndex = 26;
            this.btnAAddCar.Text = "Ajouter";
            this.btnAAddCar.UseVisualStyleBackColor = false;
            this.btnAAddCar.Click += new System.EventHandler(this.btnAAddCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(476, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Modèle";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModel.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtModel.ForeColor = System.Drawing.Color.White;
            this.txtModel.Location = new System.Drawing.Point(480, 125);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 27);
            this.txtModel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Marque";
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrand.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtBrand.ForeColor = System.Drawing.Color.White;
            this.txtBrand.Location = new System.Drawing.Point(480, 207);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(150, 27);
            this.txtBrand.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(476, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Prix";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(480, 293);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 27);
            this.txtPrice.TabIndex = 3;
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblValid.Location = new System.Drawing.Point(37, 357);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(335, 21);
            this.lblValid.TabIndex = 31;
            this.lblValid.Text = "Le véhicule a été ajouté avec succès !\r\n";
            this.lblValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValid.Visible = false;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.IndianRed;
            this.lblModel.Location = new System.Drawing.Point(37, 357);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(341, 22);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Il existe déjà ce modèle de véhicule.";
            this.lblModel.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPrice.Location = new System.Drawing.Point(37, 357);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(254, 22);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Veuillez saisir un prix valide.";
            this.lblPrice.Visible = false;
            // 
            // lblTexts
            // 
            this.lblTexts.AutoSize = true;
            this.lblTexts.BackColor = System.Drawing.Color.Transparent;
            this.lblTexts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexts.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTexts.Location = new System.Drawing.Point(37, 357);
            this.lblTexts.Name = "lblTexts";
            this.lblTexts.Size = new System.Drawing.Size(297, 22);
            this.lblTexts.TabIndex = 34;
            this.lblTexts.Text = "Veuillez remplir tous les champs.";
            this.lblTexts.Visible = false;
            // 
            // frmAAddCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.lblTexts);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.btnAAddCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCars);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAAddCar";
            this.Text = "frmAAddCar";
            this.Load += new System.EventHandler(this.frmAAddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAAddCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTexts;
    }
}