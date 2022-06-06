namespace ProjetMalek
{
    partial class frmRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRent));
            this.panelLeft = new System.Windows.Forms.Panel();
            btnSignUp = new System.Windows.Forms.Button();
            btnRent = new System.Windows.Forms.Button();
            btnSignIn = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnProfile = new System.Windows.Forms.Button();
            btnCatalog = new System.Windows.Forms.Button();
            btnHome = new System.Windows.Forms.Button();
            btnAddCar = new System.Windows.Forms.Button();
            btnDeleteCar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            btnLeave = new System.Windows.Forms.Button();
            lblTop = new System.Windows.Forms.Label();
            panelMid = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelLeft.Controls.Add(btnSignUp);
            this.panelLeft.Controls.Add(btnRent);
            this.panelLeft.Controls.Add(btnSignIn);
            this.panelLeft.Controls.Add(btnLogout);
            this.panelLeft.Controls.Add(btnProfile);
            this.panelLeft.Controls.Add(btnCatalog);
            this.panelLeft.Controls.Add(btnHome);
            this.panelLeft.Controls.Add(btnAddCar);
            this.panelLeft.Controls.Add(btnDeleteCar);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(216, 561);
            this.panelLeft.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSignUp.ForeColor = System.Drawing.Color.White;
            btnSignUp.Location = new System.Drawing.Point(-1, 186);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(216, 37);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "S\'inscrire";
            btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnRent
            // 
            btnRent.FlatAppearance.BorderSize = 0;
            btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRent.ForeColor = System.Drawing.Color.White;
            btnRent.Location = new System.Drawing.Point(0, 307);
            btnRent.Name = "btnRent";
            btnRent.Size = new System.Drawing.Size(216, 57);
            btnRent.TabIndex = 2;
            btnRent.Text = "Louer";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Visible = false;
            btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnSignIn
            // 
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSignIn.ForeColor = System.Drawing.Color.White;
            btnSignIn.Location = new System.Drawing.Point(3, 229);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new System.Drawing.Size(216, 37);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = "Se connecter";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(-1, 524);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(216, 37);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Se déconnecter";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false; 
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnProfile.ForeColor = System.Drawing.Color.White;
            btnProfile.Location = new System.Drawing.Point(-1, 370);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new System.Drawing.Size(216, 57);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Profil";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Visible = false;
            btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCatalog
            // 
            btnCatalog.FlatAppearance.BorderSize = 0;
            btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCatalog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCatalog.ForeColor = System.Drawing.Color.White;
            btnCatalog.Location = new System.Drawing.Point(0, 244);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Size = new System.Drawing.Size(216, 57);
            btnCatalog.TabIndex = 1;
            btnCatalog.Text = "Catalogue";
            btnCatalog.UseVisualStyleBackColor = true;
            btnCatalog.Visible = false;
            btnCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnHome.ForeColor = System.Drawing.Color.White;
            btnHome.Location = new System.Drawing.Point(0, 183);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(216, 57);
            btnHome.TabIndex = 0;
            btnHome.Text = "Accueil";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Visible = false;
            btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAddCar
            // 
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddCar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAddCar.ForeColor = System.Drawing.Color.White;
            btnAddCar.Location = new System.Drawing.Point(3, 433);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new System.Drawing.Size(216, 37);
            btnAddCar.TabIndex = 4;
            btnAddCar.Visible = false;
            btnAddCar.Text = "Ajouter un véhicule";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddCar.Click += new System.EventHandler(btnAddCar_Click);
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.FlatAppearance.BorderSize = 0;
            btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteCar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDeleteCar.ForeColor = System.Drawing.Color.White;
            btnDeleteCar.Location = new System.Drawing.Point(3, 481);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new System.Drawing.Size(216, 37);
            btnDeleteCar.TabIndex = 5;
            btnDeleteCar.Visible = false;
            btnDeleteCar.Text = "Supprimer un véhicule";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteCar.Click += new System.EventHandler(btnDeleteCar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelTop.Controls.Add(btnLeave);
            this.panelTop.Controls.Add(lblTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(216, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(768, 82);
            this.panelTop.TabIndex = 0;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLeave.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLeave.ForeColor = System.Drawing.Color.White;
            btnLeave.Location = new System.Drawing.Point(0, 0);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new System.Drawing.Size(90, 83);
            btnLeave.TabIndex = 1;
            btnLeave.Text = "x";
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Visible = false;
            btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // lblTop
            // 
            lblTop.BackColor = System.Drawing.Color.Transparent;
            lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTop.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTop.ForeColor = System.Drawing.Color.White;
            lblTop.Location = new System.Drawing.Point(0, 0);
            lblTop.Name = "lblTop";
            lblTop.Size = new System.Drawing.Size(768, 82);
            lblTop.TabIndex = 0;
            lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMid
            // 
            panelMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMid.Location = new System.Drawing.Point(216, 82);
            panelMid.Name = "panelMid";
            panelMid.Size = new System.Drawing.Size(768, 479);
            panelMid.TabIndex = 1;
            // 
            // frmRent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(panelMid);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Louer";
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        public static System.Windows.Forms.Button btnSignUp;
        public static System.Windows.Forms.Button btnSignIn;
        public static System.Windows.Forms.Button btnLogout;
        public static System.Windows.Forms.Button btnProfile;
        public static System.Windows.Forms.Button btnCatalog;
        public static System.Windows.Forms.Button btnHome;
        public static System.Windows.Forms.Button btnAddCar;
        public static System.Windows.Forms.Button btnDeleteCar;
        public static System.Windows.Forms.Button btnRent;
        public static System.Windows.Forms.Panel panelMid;
        public static System.Windows.Forms.Label lblTop;
        public static System.Windows.Forms.Button btnLeave;
    }
}

