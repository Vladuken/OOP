using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FoodAndDrinks.Classes
{
    class DishProxy:IFood
    {
        Dish dish;

        public DishProxy(Dish d)
        {
            dish = d;
        }
        public void Eat()
        {
            MessageBox.Show("Сейчас будет вызван метод Eat выбранного блюда", "Proxy");
            dish.Eat();
        }

    }
}
