using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Sales501
    {
        static void Main(string[] args)
        {
            Store Homemart = new Store();
            double value = 0;
            double rebateValue = 0;
            bool endTransaction = false;
            Console.WriteLine("Please Enter your Name: ");
            string name = Console.ReadLine();
            Customer customer = new Customer(name);

            Console.WriteLine("Hello, " + name + ", Welcome to Homemart please select '1' for Buying and '3' for Rebate");
            int selection = Int32.Parse(Console.ReadLine());

            Transaction X = customer.Checksout();

            while (endTransaction == false)
            {
                switch (selection)
                {
                    case 1:
                        for (int i = 1; 8 > i; i++)
                        {
                            Console.WriteLine(i + "-  " + Homemart.accessItem(i).name + "  " + Homemart.accessItem(i).cost + "$");
                        }

                        while (selection == 1)
                        {
                            Console.WriteLine("Type the Item's number to buy that Item");
                            customer.buyItem(Homemart.accessItem(Int32.Parse(Console.ReadLine())));
                            Console.WriteLine("Type '1' to buy another item, '2' to return an item or '4' to checkout");
                            selection = Int32.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        foreach (KeyValuePair<string, Item> s in customer.owendItems)
                        {
                            Console.WriteLine("- " + s.Value.name + "  " + s.Value.cost + "$");
                        }
                        Console.WriteLine("type an item name to return it ");
                        customer.returnItem(customer.owendItems[Console.ReadLine()]);
                        if (customer.owendItems.Count < 1)
                        {
                            Console.WriteLine("Type '1' to buy an item or '4' to checkout");
                            selection = Int32.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Type '1' to buy an item, '2' to return another item or '4' to checkout");
                            selection = Int32.Parse(Console.ReadLine());
                        }
                        break;
                    case 3:
                        for (int i = 1; 8 > i; i++)
                        {
                            Console.WriteLine(i + "-  " + Homemart.accessItem(i).name + "  " + Homemart.accessItem(i).cost + "$");
                        }
                        {
                            while (selection == 3)
                            {
                                Console.WriteLine("Type the Item's number to buy that Item");
                                int c = Int32.Parse(Console.ReadLine());
                                X.addRebate(Homemart.accessItem(c));
                                customer.buyItem(Homemart.accessItem(c));
                                Console.WriteLine("Type '3' to buy another item with rebate, '2' to return an item or '4' to checkout");
                                selection = Int32.Parse(Console.ReadLine());
                            }
                        }

                        break;
                    case 4:
                        foreach (KeyValuePair<string, Item> s in customer.owendItems)
                        {
                            value += s.Value.cost;
                        }
                        rebateValue = +X.generateRebateCheck();
                        Console.WriteLine("the cost of your transaction is: " + value + "$" + " and your rebate is " + rebateValue + "$  thank you for shooping.");
                        endTransaction = true;
                        break;
                }
            }

            Console.ReadLine();




        }

    }
}
