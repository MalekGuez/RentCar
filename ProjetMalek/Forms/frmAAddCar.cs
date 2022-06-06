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
    public partial class frmAAddCar : Form
    {
        public frmAAddCar()
        {
            InitializeComponent();
        }
        private void frmAAddCar_Load(object sender, EventArgs e)
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
            lblPrice.Visible = false;
            lblModel.Visible = false;
            lblTexts.Visible = false;
            lblValid.Visible = false;
            if (txtBrand.Text != "" && txtModel.Text != "" && (txtPrice.Text != "")) {
                Console.WriteLine(Car.modeleExists(txtModel.Text));
                if (!Car.modeleExists(txtModel.Text))
                {
                    if (txtPrice.Text.All(char.IsDigit))
                    {
                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO Vehicule (modele, marque, prix) VALUES ('" + txtModel.Text + "','" + txtBrand.Text + "'," + txtPrice.Text +")", frmRent.cnGC);
                        cmdInsert.ExecuteNonQuery();

                        txtBrand.Text = "";
                        txtModel.Text = "";
                        txtPrice.Text = "";
                        setCarsList();

                        lblValid.Visible = true;
                    }
                    else
                    {
                        lblPrice.Visible = true;
                    }
                }
                else
                {
                    lblModel.Visible = true;
                }
            }
            else
            {
                lblTexts.Visible = true;
            }
            
        }
    }
}
