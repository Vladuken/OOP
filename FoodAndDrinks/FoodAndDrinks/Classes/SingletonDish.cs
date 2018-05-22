using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAndDrinks.Classes
{
    public class SingletonDish : Dish
    {
        private static SingletonDish instance;
        private SingletonDish(string title,int calories, AdditiveList adlist):base(title,calories)
        {
            this.AdsList = adlist;
        }

        public static SingletonDish GetInstance(Dish dish)
        {
            if (instance == null)
            {
                instance = new SingletonDish(dish.Title,dish.Calories,dish.AdsList);
            }
            return instance;
        }
    }
}
