using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FoodAndDrinks.Classes
{
    [Serializable]
    [DataContract]
    public abstract class Dish : IFood
    {
        
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Calories { get; set; }
        public virtual string DishType { get { return typeof(Dish).Name; } }

        [DataMember]
        public AdditiveList AdsList
        {
            get;
            set;
        }
        /*
        public Dish(string title, int calories, AdditiveList addlist)
        {
            Title = title;
            Calories = calories;
            AddList = addlist;
        }*/


        public Dish(string title, int calories)
        {
            Title = title;
            Calories = calories;
            AdsList = null;
        }
        public Dish() { }


        public void AddAdditive(AdditiveList addlist)
        {
            AdsList = addlist;
        }

        public virtual void Eat()
        {
            MessageBox.Show("СЪЕДЕНО", "Food");
        }

    }
}
