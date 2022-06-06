using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetMalek
{
    public partial class frmRent : Form
    {
        public static Form CurrentForm
        {
            get { return _currentForm; }

            set
            {
                _currentForm = value;
                OpenChildForm(_currentForm, panelMid);
            }
        }

        public static SqlConnection cnGC;

        private static Form _currentForm;
        public static Form activeForm;

        public static int userId;


        public static string name;
        public static string surname;
        public static string currentUser;
        public static int isAdmin;
        

 
        public frmRent()
        {
            InitializeComponent();

            try
            {
                cnGC = new SqlConnection("Server=localhost;Integrated security=SSPI;database=RentCar");
                cnGC.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        // FUNCTIONS --------------------------------------------------------------------------------------

        public static void setMenu(bool display)
        {
            if (display)
            {
                btnHome.Visible = true;
                btnCatalog.Visible = true;
                btnRent.Visible = true;
                btnProfile.Visible = true;

                if (isAdmin == 1)
                {
                    btnAddCar.Visible = true;
                    btnDeleteCar.Visible = true;
                }

                btnSignIn.Visible = false;
                btnSignUp.Visible = false;
            }
            else
            {
                btnHome.Visible = false;
                btnCatalog.Visible = false;
                btnRent.Visible = false;
                btnProfile.Visible = false;
                btnLogout.Visible = false;
                btnSignIn.Visible = true;
                btnSignUp.Visible = true;
            }
        }

        // OPEN CHILD FORM --------------------------------------------------------------------------------------

        public static void OpenChildForm(Form childForm, Panel panel)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            switch (childForm.Text)
            {
                case "frmHome":
                    btnLeave.Visible = false;
                    lblTop.Text = "ACCUEIL";
                    break;
                case "frmRentCar":
                    btnLeave.Visible = true;
                    lblTop.Text = "LOUER DES VÉHICULES";
                    break;
                case "frmCatalog":
                    btnLeave.Visible = true;
                    lblTop.Text = "CATALOGUE";
                    break;
                case "frmProfile":
                    btnLeave.Visible = true;
                    lblTop.Text = "PROFIL";
                    break;
                case "frmSignIn":
                    btnLeave.Visible = false;
                    lblTop.Text = "CONNEXION";
                    break;
                case "frmSignUp":
                    btnLeave.Visible = false;
                    lblTop.Text = "INSCRIPTION";
                    break;
                case "frmAAddCar":
                    btnLeave.Visible = false;
                    lblTop.Text = "AJOUTER UN VÉHICULE";
                    break;
                case "frmADeleteCar":
                    btnLeave.Visible = false;
                    lblTop.Text = "SUPPRIMER UN VÉHICULE";
                    break;
            }
        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSignIn(), panelMid);
        }

        // BUTTONS --------------------------------------------------------------------------------------
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmHome(), panelMid);
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmCatalog(), panelMid);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmRentCar(), panelMid);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmProfile(), panelMid);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSignIn(), panelMid);

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSignUp(), panelMid);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            setMenu(false);

            if(isAdmin == 1)
            {
                btnAddCar.Visible = false;
                btnDeleteCar.Visible = false;
            }
            currentUser = "";

            btnLeave.Visible = false;

            lblTop.Text = "CONNEXION";
            OpenChildForm(new Forms.frmSignIn(), panelMid);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            btnLeave.Visible = false;
            OpenChildForm(new Forms.frmHome(), panelMid);
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmAAddCar(), panelMid);
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmADeleteCar(), panelMid);
        }
    }
}
