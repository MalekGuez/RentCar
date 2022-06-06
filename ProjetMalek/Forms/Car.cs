using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetMalek.Forms
{
    internal class Car
    {
        private static List<Car> carsList = new List<Car>();

        public int Id { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Prix { get; set; }

        public Car(int id, string modele, string marque, int prix)
        {
            Id = id;
            Marque = marque;
            Modele = modele;
            Prix = prix;
        }
        public static Car getCarByModel(string modele)
        {
            return carsList.Find(c => c.Modele == modele);
        }
        public static void getCarsWithId()
        {
            carsList.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicule ORDER BY marque ASC", frmRent.cnGC);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    carsList.Add(new Car(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), (int)dr.GetDouble(3)));
                }

                dr.Close();
                dr = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dataReader :" + ex.Message);
            }
        }
        public static List<Car> getCars()
        {
            return carsList;
        }

        public static Boolean modeleExists(string modele)
        {
            return carsList.Exists(c => c.Modele == modele);
        }

        public static void addCar(string modele, string marque, int prix)
        {
            if (!modeleExists(modele))
            {
                SqlCommand cmdInsertCar = new SqlCommand("INSERT INTO Vehicule (modele, marque, prix) VALUES ('" + modele + "','" + marque + "', " + prix +")", frmRent.cnGC);
                cmdInsertCar.ExecuteNonQuery();
            }
            else MessageBox.Show("Ce modèle de véhicule existe déjà !");
        }

        public static void deleteCar(string modele)
        {
            carsList.Remove(getCarByModel(modele));
        }
    }
}
