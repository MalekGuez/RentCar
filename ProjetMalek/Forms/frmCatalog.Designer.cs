namespace ProjetMalek.Forms
{
    partial class frmCatalog
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnSI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
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
            this.lstCars.Location = new System.Drawing.Point(37, 110);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(339, 210);
            this.lstCars.TabIndex = 0;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(425, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Modèle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prix de vente : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(425, 104);
            this.lblName.MinimumSize = new System.Drawing.Size(130, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 30);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "                             ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(425, 184);
            this.lblPrice.MinimumSize = new System.Drawing.Size(130, 30);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(130, 30);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "                             ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(600, 104);
            this.lblModel.MinimumSize = new System.Drawing.Size(130, 30);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(130, 30);
            this.lblModel.TabIndex = 18;
            this.lblModel.Text = "                             ";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSI
            // 
            this.btnSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSI.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSI.FlatAppearance.BorderSize = 2;
            this.btnSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSI.ForeColor = System.Drawing.Color.White;
            this.btnSI.Location = new System.Drawing.Point(546, 376);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(181, 46);
            this.btnSI.TabIndex = 19;
            this.btnSI.Text = "Ajouter à la liste";
            this.btnSI.UseVisualStyleBackColor = false;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(417, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Durée de réservation :";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuration.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtDuration.ForeColor = System.Drawing.Color.White;
            this.txtDuration.Location = new System.Drawing.Point(604, 285);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(71, 27);
            this.txtDuration.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Catalogue des voitures :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(683, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "jours";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAdd.Location = new System.Drawing.Point(425, 342);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(296, 21);
            this.lblAdd.TabIndex = 24;
            this.lblAdd.Text = "Le véhicule a été ajouté à votre liste.\r\n";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdd.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDuration.Location = new System.Drawing.Point(482, 318);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(245, 21);
            this.lblDuration.TabIndex = 25;
            this.lblDuration.Text = "Veuillez saisir une durée valide.";
            this.lblDuration.Visible = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSelect.Location = new System.Drawing.Point(33, 342);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(259, 21);
            this.lblSelect.TabIndex = 26;
            this.lblSelect.Text = "Veuillez sélectionner un véhicule";
            this.lblSelect.Visible = false;
            // 
            // frmCatalog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCars);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCatalog";
            this.Text = "frmCatalog";
            this.Load += new System.EventHandler(this.frmCatalogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSelect;
    }
}