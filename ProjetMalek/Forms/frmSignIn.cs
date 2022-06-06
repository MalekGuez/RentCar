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

namespace ProjetMalek.Forms
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            lblTextsTest.Visible = false;
            lblUNPWTest.Visible = false;
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    SqlCommand cmdExists = new SqlCommand("SELECT * FROM Utilisateur WHERE username='" + txtUsername.Text.Trim() + "' AND mdp=HASHBYTES('SHA2_256','" + txtPassword.Text.Trim() + "')", frmRent.cnGC);

                    SqlDataReader dr = cmdExists.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            frmRent.isAdmin = (int)dr["administrateur"];
                            frmRent.userId = (int)dr["id"];
                            frmRent.name = (string)dr["nom"];
                            frmRent.surname = (string)dr["prenom"];
                        }

                        frmRent.currentUser = txtUsername.Text;
                        frmRent.CurrentForm = new frmHome();
                        frmRent.setMenu(true);
                        frmRent.btnLogout.Visible = true;
                    }
                    else lblUNPWTest.Visible = true;

                    dr.Close();
                    dr = null;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de requête :" + ex.Message);
                }
            }
            else lblTextsTest.Visible = true;
        }
    }
}
