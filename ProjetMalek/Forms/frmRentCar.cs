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
    public partial class frmRentCar : Form
    {
        public frmRentCar()
        {
            InitializeComponent();
        }

        private void frmRentCar_Load(object sender, EventArgs e)
        {
            if(Basket.getListByUser(frmRent.currentUser) != null)
            {
                setCarsInList();
            }
        }

        private void setCarsInList()
        {
            lstCurrentCars.Items.Clear();

            foreach (KeyValuePair<Car, int> kvp in Basket.getListByUser(frmRent.currentUser).userCarsList)
            {                
                lstCurrentCars.Items.Add(kvp.Key.Modele + " | " + kvp.Key.Marque + " | " + kvp.Key.Prix + " € | " + kvp.Value + " jours");
            }
            lblTotal.Text = Basket.getListByUser(frmRent.currentUser).getPrice() + "€";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstCurrentCars.SelectedIndex > -1)
            {
                string[] carInfo;
                carInfo = lstCurrentCars.SelectedItem.ToString().Split('|');

                string modele = carInfo[0].Trim();
                Basket.getListByUser(frmRent.currentUser).removeCar(modele);
                setCarsInList();
            }           
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            lblList.Visible = false;
            if(lstCurrentCars.Items.Count > 0)
            {
                Basket l = Basket.getListByUser(frmRent.currentUser);
                DateTime dateR = DateTime.Now;
                double total = l.getPrice();

                SqlCommand cmdInsertCommand = new SqlCommand("INSERT INTO Reservation (dateR, total, idUtilisateur) VALUES ('" + dateR + "', " + total + ", " + frmRent.userId + "); SELECT SCOPE_IDENTITY()", frmRent.cnGC);
                int id = int.Parse(cmdInsertCommand.ExecuteScalar().ToString());

                foreach (KeyValuePair<Car, int> kvp in l.userCarsList)
                {
                    SqlCommand cmdInsertLigneCmd = new SqlCommand("INSERT INTO LigneReservation (idReservation, idVehicule, duree) VALUES (" + id + ", " + kvp.Key.Id + ", " + kvp.Value + ")", frmRent.cnGC);
                    cmdInsertLigneCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Réservation effectuée avec succès !\nTotal : " + l.getPrice() + "€");
                l.clearList();

                lstCurrentCars.Items.Clear();
                lblTotal.Text = "0€";
                lblList.Visible = false;
            }
            else
            {
                lblList.Visible = true;
            }
        }
    }
}
