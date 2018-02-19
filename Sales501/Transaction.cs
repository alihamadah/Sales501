using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    /// <summary>
    /// keep track of the rebate and generating it. 
    /// </summary>
    class Transaction
    {       
        /// <summary>
        ///   list of the items to be rebated. 
        /// </summary>                       
        private List<Item> rebatedItems = new List<Item>();
        public int count
        {
            get;
            set;
        }
        public Transaction (Customer c)
        {
         
        }

        /// <summary>
        /// rebate an item and add it to the rebated item list.
        /// </summary>
        /// <param name="r"></param>
        public void addRebate(Item r)
        {
            r.cost = 0.11 * r.cost;
            rebatedItems.Add(r);
            count++;
        }
        /// <summary>
        /// generate the rebate check
        /// </summary>
        /// <returns></returns>
        public double generateRebateCheck()
        {
            double x = 0;
            for (int i = 0; rebatedItems.Count > i; i++)
            {
                x += rebatedItems[i].cost;
            }
            return x;
        }
    }
}
