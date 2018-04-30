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
    public class StarterDish : Dish
    {
        /*
         A starter dish is a small portion of a food item, served as an introduction to a meal.
         It may be a soup, a salad, or something to nibble on.
         */
        public StarterDish() { }
        public StarterDish(string title, int calories) : base(title,calories) { }

        public override string DishType { get { return typeof(StarterDish).Name; } }

    }
}
