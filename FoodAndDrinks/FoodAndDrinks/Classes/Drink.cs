using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FoodAndDrinks.Classes
{
    [Serializable]
    [DataContract]
    public class Drink : FinalDish
    {
        public Drink() { }
        public Drink(string title, int calories) : base(title, calories) { }

        public override string DishType { get { return typeof(Drink).Name; } }
    }
}
