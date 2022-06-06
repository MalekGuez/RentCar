using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMalek.Forms
{
    public partial class frmCatalog : Form
    {
        public frmCatalog()
        {
            InitializeComponent();
        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] carInfo;

            carInfo = lstCars.SelectedItem.ToString().Split('|');
          
            lblName.Text = carInfo[0].Trim();
            lblModel.Text = carInfo[1].Trim();
            lblPrice.Text = carInfo[2].Trim();
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            lblAdd.Visible = false;
            lblDuration.Visible = false;
            lblSelect.Visible = false;

            if (lstCars.SelectedIndex > -1)
            {
                if(txtDuration.Text.All(char.IsDigit) && txtDuration.Text != "")
                {
                    if (Basket.getListByUser(frmRent.currentUser) == null)
                    {
                        Basket.createList(frmRent.currentUser);
                    }

                    string modele = Car.getCars()[lstCars.SelectedIndex].Modele;
                    string marque = Car.getCars()[lstCars.SelectedIndex].Marque;
                    int prix = Car.getCars()[lstCars.SelectedIndex].Prix;

                    Basket.getListByUser(frmRent.currentUser).addCar(modele, Int32.Parse(txtDuration.Text));

                    lblAdd.Visible = true;
                    txtDuration.Text = "";
                }
                else
                {
                    lblDuration.Visible = true;
                }
            }
            else
            {
                lblSelect.Visible = true;
            }
        }

        private void frmCatalogue_Load(object sender, EventArgs e)
        {
            Car.getCarsWithId();
            lstCars.Items.Clear();

            foreach (Car c in Car.getCars())
            {
                lstCars.Items.Add(c.Modele + " | " + c.Marque + " | " + c.Prix + "€");
            }
        }
    }
}
