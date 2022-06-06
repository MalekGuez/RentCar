namespace ProjetMalek.Forms
{
    partial class frmRentCar
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
            this.lstCurrentCars = new System.Windows.Forms.ListBox();
            this.lblLouer = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCurrentCars
            // 
            this.lstCurrentCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstCurrentCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCurrentCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCurrentCars.ForeColor = System.Drawing.Color.White;
            this.lstCurrentCars.FormattingEnabled = true;
            this.lstCurrentCars.ItemHeight = 21;
            this.lstCurrentCars.Location = new System.Drawing.Point(57, 78);
            this.lstCurrentCars.Name = "lstCurrentCars";
            this.lstCurrentCars.Size = new System.Drawing.Size(323, 231);
            this.lstCurrentCars.TabIndex = 0;
            // 
            // lblLouer
            // 
            this.lblLouer.AutoSize = true;
            this.lblLouer.ForeColor = System.Drawing.Color.White;
            this.lblLouer.Location = new System.Drawing.Point(53, 40);
            this.lblLouer.Name = "lblLouer";
            this.lblLouer.Size = new System.Drawing.Size(554, 21);
            this.lblLouer.TabIndex = 9;
            this.lblLouer.Text = "Veuillez sélectionner des véhicules depuis le catalogue afin de les louer";
            this.lblLouer.Visible = false;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRent.FlatAppearance.BorderSize = 2;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(561, 333);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(150, 46);
            this.btnRent.TabIndex = 10;
            this.btnRent.Text = "Louer";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(57, 333);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 46);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Retirer de la liste";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(464, 288);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 21);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0€";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.ForeColor = System.Drawing.Color.IndianRed;
            this.lblList.Location = new System.Drawing.Point(104, 406);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(512, 22);
            this.lblList.TabIndex = 14;
            this.lblList.Text = "Il faut au moins un véhicule dans la liste afin de le louer.";
            this.lblList.Visible = false;
            // 
            // frmRentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.lblLouer);
            this.Controls.Add(this.lstCurrentCars);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRentCar";
            this.Text = "frmRentCar";
            this.Load += new System.EventHandler(this.frmRentCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCurrentCars;
        private System.Windows.Forms.Label lblLouer;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblList;
    }
}