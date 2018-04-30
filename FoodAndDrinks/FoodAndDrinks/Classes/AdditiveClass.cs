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
    public class AdditiveClass
    {
        [DataMember]
        public string Name { get; set; }
        public AdditiveClass()
        {

        }
        public AdditiveClass(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
