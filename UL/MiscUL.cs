using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;
using Tesha_s_Coffee_Shop.UL;

namespace Tesha_s_Coffee_Shop.UL
{
    internal class MiscUL
    {
        public static string getCoffeeShopName()
        {
            Console.Write("Enter Shop Name: ");
            string shopName= Console.ReadLine();
            CoffeeShop coffeeShop = new CoffeeShop();
            coffeeShop.setCoffeeShopName(shopName);
            return shopName;
        }
        public static void header(string shopName)
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*********                                 *********");
            Console.WriteLine("                   " + shopName);
            Console.WriteLine("*********                                 *********");
            Console.WriteLine("***************************************************");
        }
        public static char mainMenu()
        {
            char option;
            Console.WriteLine("1. Add a menu item ");
            Console.WriteLine("2. View the cheapest item in the menu ");
            Console.WriteLine("3. View the drink's menu ");
            Console.WriteLine("4. View the food menu ");
            Console.WriteLine("5. Add order ");
            Console.WriteLine("6. Fullfill the order ");
            Console.WriteLine("7. View the order's list ");
            Console.WriteLine("8. Total payable amount ");
            Console.WriteLine("9. Exit ");
            Console.Write("Enter option...");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        public static void clearScreen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
