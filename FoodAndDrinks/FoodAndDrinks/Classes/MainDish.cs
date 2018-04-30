using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FoodAndDrinks.Classes
{
    [Serializable]
    [DataContract]
    public class MainDish : Dish
    {
        /*
         * A main dish is the primary dish of a meal, around which the meal is built. 
         * It is usually meat or fish, 
         * or something like a casserole with meat or fish in it, 
         * and is usually accompanied by one or more side dishes.
         * */


        public MainDish() { }
        public MainDish(string title, int calories) : base(title, calories) { }

        public override string DishType { get { return typeof(MainDish).Name; } }
    }
}
