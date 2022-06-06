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
    public partial class frmADeleteCar : Form
    {
        public frmADeleteCar()
        {
            InitializeComponent();
        }
        private void frmADeleteCar_Load(object sender, EventArgs e)
        {
            setCarsList();
        }

        private void setCarsList()
        {
            Car.getCarsWithId();
            lstCars.Items.Clear();

            foreach (Car c in Car.getCars())
            {
                lstCars.Items.Add(c.Modele + " | " + c.Marque + " | " + c.Prix + "€");
            }
        }

        private void btnAAddCar_Click(object sender, EventArgs e)
        {
            lblReserved.Visible = false;
            lblValid.Visible = false;

            if (lstCars.SelectedIndex > -1)
            {
                string modele = Car.getCars()[lstCars.SelectedIndex].Modele;

                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) nb FROM LigneReservation JOIN Vehicule ON LigneReservation.idVehicule = Vehicule.id WHERE Vehicule.modele='" + modele + "'", frmRent.cnGC);

                if ((int)cmdCount.ExecuteScalar() == 0)
                {
                    for (int i = 0; i < Basket.baskets.Count; i++)
                    {
                        for (int j = 0; j < Basket.baskets[i].userCarsList.Count; j++)
                        {
                            if (Basket.baskets[i].userCarsList.ElementAt(j).Key.Modele == modele)
                            {
                                Basket.baskets[i].userCarsList.Remove(Basket.baskets[i].userCarsList.ElementAt(j).Key);
                            }
                        }
                    }

                    SqlCommand cmdRemoveCar = new SqlCommand("DELETE FROM Vehicule WHERE modele ='" + modele + "'", frmRent.cnGC);
                    cmdRemoveCar.ExecuteNonQuery();

                    lblValid.Visible = true;
                    setCarsList();
                }
                else
                {
                    lblReserved.Visible = true;
                }
            }
        }
    }
}
