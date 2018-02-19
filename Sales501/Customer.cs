using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{ /// <summary>
  /// This class is responisle for keeping track of the items the customers buy
  /// </summary>
    class Customer
    {

        public string name;
        /// <summary>
        /// the Items the customer have already bought.
        /// </summary>
        public Dictionary<string, Item> owendItems = new Dictionary<string, Item>();

        public int count
        {
            get;
            set;
        }
        public Customer(string n)
        {
            name = n;
        }
        /// <summary>
        ///  creating an instance of the Transaction class.
        /// </summary>
        /// <returns></returns>
        public Transaction Checksout()
        {
            return new Transaction(this);
        }
        /// <summary>
        /// buy an item from the store item list and add it to the owned items by the customers.
        /// </summary>
        /// <param name="x">the item to be bought</param>
        public void buyItem(Item x)
        {
            owendItems.Add(x.name, x);
            count++;
        }
        /// <summary>
        /// it return and an item the user already bought and remove it from the owend item list
        /// </summary>
        /// <param name="x">item to be returned</param>
        public void returnItem(Item x)
        {
            owendItems.Remove(x.name);
            count--;
        }

    }
}