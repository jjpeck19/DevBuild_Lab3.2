using System;
using System.Collections.Generic;

namespace DevBuild_Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //shopping list
            //display a list of at least 8 items names and places

            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            shop.Add("apple", (decimal).99);
            shop.Add("banana", (decimal).59);
            shop.Add("cauliflower", (decimal)1.59);
            shop.Add("dragonfruit", (decimal)2.19);
            shop.Add("elderberry", (decimal)1.79);
            shop.Add("figs", (decimal)2.09);
            shop.Add("grapefruit", (decimal)1.99);
            shop.Add("honeydew", (decimal)3.49);

            Console.WriteLine("\nWelcome to Guenther's Market!\n");
            //Console.WriteLine(shop[""]);

            List<string> item = new List<string>();
            List<decimal> price = new List<decimal>();
            //item.Add("apple");
            //item.Add("banana");
            //item.Add("cauliflower");
            //item.Add("dragonfruit");
            //item.Add("elderberry");
            //item.Add("figs");
            //item.Add("grapefruit");
            //item.Add("honeydew");
            //price.Add((decimal).99);
            //price.Add((decimal).59);
            //price.Add((decimal)1.59);
            //price.Add((decimal)2.19);
            //price.Add((decimal)1.79);
            //price.Add((decimal)2.09);
            //price.Add((decimal)1.99);
            //price.Add((decimal)3.49);

            //ask the user to enter an item name
            //          if that item exists, display that item and price and
            //          add that item and its price to the user's order/
            //      if that item doesn't exist, display an error and re-[rpmt the user.
            //      (display the menu again if you'd like.)
            while (true)
            {
                Console.WriteLine("item\t\tPrice");
                Console.WriteLine("==================================");


                foreach (var pick in shop)
                {

                    // key is first data type in the list, value is the second data type in the list
                    //               key = string         value = int
                    Console.WriteLine($"{pick.Key}\t\t{pick.Value} .");
                }

                //bool shopping = true;
                //while (shopping)
                //{
                Console.WriteLine("\n\nwhat item would you like to order?\n");

                string entry = Console.ReadLine();

                if (shop.ContainsKey(entry) == false)
                {
                    Console.WriteLine("Sorry, that item is not available.");
                    //should have a while loop
                }
                else
                {

                    item.Add(entry);
                    //decimal count = Int32.Parse(Console.ReadLine());

                    price.Add(shop[entry]);
                    Console.WriteLine("\nitems in my cart and total\n");
                    for (int i = 0; i < item.Count; i++)
                    {

                        Console.WriteLine(item[i]);
                        Console.WriteLine(price[i]);

                        Console.WriteLine("would you like to continue shopping? y/n");

                        if (Console.ReadLine() == "y")
                        {
                            Console.WriteLine("item\t\tPrice");
                            Console.WriteLine("==================================");
                            foreach (var pick in shop)
                            {

                                // key is first data type in the list, value is the second data type in the list
                                //               key = string         value = int
                                Console.WriteLine($"{pick.Key}\t\t{pick.Value} .");
                            }
                            item.Add(entry);
                            //decimal count = Int32.Parse(Console.ReadLine());

                            price.Add(shop[entry]);

                        }
                        else
                        {
                            Console.WriteLine("thanks for your order!");
                            decimal total = 0;
                            for (int n = 0; n < price.Count; n++)
                            {
                                Console.WriteLine($"adding {item[n]} to cart at ${price[n]}");
                                total = total + price[n] / item.Count;
                            }

                            Console.WriteLine($"your total is " + total);

                            //shopping = false;
                        }
                    }




                }






            }

        }
    }
}