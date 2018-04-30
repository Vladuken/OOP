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
    public class Dessert: FinalDish
    {
        public Dessert() { }
        public Dessert(string title, int calories) : base(title, calories) { }

        public override string DishType { get { return typeof(Dessert).Name; } }
    }
}
