using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Store
    {
        /// <summary>
        /// create the store.
        /// </summary>
        private Dictionary<int, Item> storeItems = new Dictionary<int, Item>();
        
        /// <summary>
        /// initialize te items in the store thats avalibe for the user.
        /// </summary>
        public Store ()
        {
            storeItems.Add(1, new Item("Plastic Chair", 11));
            storeItems.Add(2, new Item("Wooden Table", 40));
            storeItems.Add(3, new Item("Round Glass-Table", 100));
            storeItems.Add(4, new Item("Cardinal Sofa", 180));
            storeItems.Add(5, new Item("Striped curatin", 30));
            storeItems.Add(6, new Item("Office Wheel Chair", 120));
            storeItems.Add(7, new Item("Wooden Bookshelf", 80));
        }
        /// <summary>
        ///  give an access to individual item so it can be referenced by other classes.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Item accessItem(int x)
        {
           return  storeItems[x];
        }
    }
}
