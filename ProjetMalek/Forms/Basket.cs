using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetMalek.Forms
{
    internal class Basket
    {
        public static List<Basket> baskets = new List<Basket>();
        public Dictionary<Car, int> userCarsList = new Dictionary<Car, int>();
        private string Username { get; set; }

        public Basket(string username)
        {
            Username = username;
        }

        public static void createList(string username) 
        { 
            baskets.Add(new Basket(username));
        }

        public void addCar(string modele, int duration)
        {
            for (int j = 0; j < userCarsList.Count; j++)
            {
                if (userCarsList.ElementAt(j).Key.Modele == modele)
                {
                    return;
                }
            }
            userCarsList.Add(Car.getCarByModel(modele), duration);
        }

        public void removeCar(string modele)
        {
            for (int j = 0; j < userCarsList.Count; j++)
            {
                if (userCarsList.ElementAt(j).Key.Modele == modele)
                {
                    userCarsList.Remove(userCarsList.ElementAt(j).Key);
                    return;
                }
            }
        }

        public void clearList()
        {
            userCarsList.Clear();
        }

        public static Basket getListByUser(string username) { return baskets.Find(l => l.Username == username); }

        public double getPrice()
        {
            double price = 0;
            foreach (KeyValuePair<Car, int> kvp in userCarsList)
            {
                price += kvp.Key.Prix;
            }
            return price;
        }
    }
}
