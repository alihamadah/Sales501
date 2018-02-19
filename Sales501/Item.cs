using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Item
    {
       /// <summary>
       /// creates a new item and initialize its name and cost.
       /// </summary>
        public string name
        {
            get;
            set;
        }
        public double cost
        {
            get;
            set;
        }
        public Item(string n , int c)
        {
            name = n;
            cost = c;
        }
       
    }
}
