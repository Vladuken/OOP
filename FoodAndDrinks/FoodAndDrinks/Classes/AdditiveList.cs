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
    public class AdditiveList
    {
        [DataMember]
        public List<AdditiveClass> AdsList { get; set; }

        public AdditiveList(List<AdditiveClass> list)
        {
            AdsList = list;
        }

        public AdditiveList()
        {
            AdsList = new List<AdditiveClass>();
        }

        public void Add(AdditiveClass adds)
        {
            AdsList.Add(adds);
        }

        public void AddFirst(AdditiveClass adds)
        {
            AdsList.Insert(0, adds);
        }

        public void RemoveLast()
        {
            AdsList.RemoveAt(AdsList.Count() - 1);
        }
        public int Count()
        {
            return AdsList.Count();
        }
        public void Clear()
        {
            AdsList.Clear();
        }
        public void Remove(string name)
        {
            foreach(var item in AdsList)
            {
                if (item.Name == name)
                {
                    AdsList.Remove(item);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return String.Join("\n",AdsList);
        }
    }
}
