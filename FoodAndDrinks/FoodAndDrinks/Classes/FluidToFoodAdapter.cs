using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAndDrinks.Classes
{
    class FluidToFoodAdapter : IFood
    {
        Fluid fluid;

        public FluidToFoodAdapter(Fluid a)
        {
            fluid = a;
        }

        public void Eat()
        {
            fluid.Drink();
        }
    }
}
