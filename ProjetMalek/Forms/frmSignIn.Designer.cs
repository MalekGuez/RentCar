namespace ProjetMalek.Forms
{
    partial class frmSignIn
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSI = new System.Windows.Forms.Button();
            this.lblTextsTest = new System.Windows.Forms.Label();
            this.lblUNPWTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(146, 186);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 27);
            this.txtUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(461, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mot de passe";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(463, 186);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 27);
            this.txtPassword.TabIndex = 9;
            // 
            // btnSI
            // 
            this.btnSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSI.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSI.FlatAppearance.BorderSize = 2;
            this.btnSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSI.ForeColor = System.Drawing.Color.White;
            this.btnSI.Location = new System.Drawing.Point(305, 333);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(150, 46);
            this.btnSI.TabIndex = 11;
            this.btnSI.Text = "Se connecter";
            this.btnSI.UseVisualStyleBackColor = false;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // lblTextsTest
            // 
            this.lblTextsTest.AutoSize = true;
            this.lblTextsTest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextsTest.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTextsTest.Location = new System.Drawing.Point(237, 254);
            this.lblTextsTest.Name = "lblTextsTest";
            this.lblTextsTest.Size = new System.Drawing.Size(297, 22);
            this.lblTextsTest.TabIndex = 12;
            this.lblTextsTest.Text = "Veuillez remplir tous les champs.";
            this.lblTextsTest.Visible = false;
            // 
            // lblUNPWTest
            // 
            this.lblUNPWTest.AutoSize = true;
            this.lblUNPWTest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUNPWTest.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUNPWTest.Location = new System.Drawing.Point(179, 254);
            this.lblUNPWTest.Name = "lblUNPWTest";
            this.lblUNPWTest.Size = new System.Drawing.Size(409, 22);
            this.lblUNPWTest.TabIndex = 13;
            this.lblUNPWTest.Text = "Nom d\'utilisateur ou mot de passe incorrect.";
            this.lblUNPWTest.Visible = false;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.lblUNPWTest);
            this.Controls.Add(this.lblTextsTest);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSignIn";
            this.Text = "frmSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Label lblTextsTest;
        private System.Windows.Forms.Label lblUNPWTest;
    }
}