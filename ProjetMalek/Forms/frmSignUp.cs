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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSU_Click(object sender, EventArgs e)
        {
            lblTextsTest.Visible = false;
            lblUsernameTest.Visible = false;
            if (txtName.Text != "" && txtSurname.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    SqlCommand cmdExists = new SqlCommand("SELECT COUNT(*) AS nb FROM Utilisateur WHERE username='" + txtUsername.Text.Trim() + "'", frmRent.cnGC);
                    if ((int)cmdExists.ExecuteScalar() == 0)
                    {
                        SqlCommand cmdInsertUser = new SqlCommand("INSERT INTO Utilisateur (username, mdp, nom, prenom, administrateur) VALUES ('"
                            + txtUsername.Text.Trim() + "'," +
                            "HASHBYTES('SHA2_256','" + txtPassword.Text.Trim() + "'),'"
                            + txtName.Text.Trim() + "','"
                            + txtSurname.Text.Trim() +
                            "', 0)"
                        , frmRent.cnGC);
                        cmdInsertUser.ExecuteNonQuery();
                        lblValid.Visible = true;

                    }
                    else
                    {
                        lblUsernameTest.Visible = true;
                    }
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
