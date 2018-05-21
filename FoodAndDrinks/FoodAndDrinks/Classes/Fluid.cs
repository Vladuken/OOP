using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows;

namespace FoodAndDrinks.Classes
{
    [Serializable]
    [DataContract]
    public class Fluid : FinalDish, IDrink
    {
        public Fluid() { }
        public Fluid(string title, int calories) : base(title, calories) { }

        public override string DishType { get { return typeof(Fluid).Name; } }

     
        public void Drink()
        {
            MessageBox.Show("ВЫПИТО", "Drink");
        }

    }
}
