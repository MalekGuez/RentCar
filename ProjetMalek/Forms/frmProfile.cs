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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            lblName.Text = frmRent.name;
            lblSurname.Text = frmRent.surname;

            try
            {
                SqlCommand cmdExists = new SqlCommand("SELECT * FROM Reservation WHERE idUtilisateur=" + frmRent.userId + " ORDER BY dateR DESC", frmRent.cnGC);
                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Reservation WHERE idUtilisateur=" + frmRent.userId, frmRent.cnGC);

                lblDuration.Text = cmdCount.ExecuteScalar().ToString();

                SqlDataReader dr = cmdExists.ExecuteReader();

                    while (dr.Read())
                    {
                        lstReserv.Items.Add(Convert.ToDateTime(dr["dateR"]).ToString("Le dd/MM/yyyy à HH:mm") + " | " + dr["total"] + "€");
                    }

                dr.Close();
                dr = null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur de requête :" + ex.Message);
            }
        }
    }
}
