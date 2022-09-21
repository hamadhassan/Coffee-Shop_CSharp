using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;

namespace Tesha_s_Coffee_Shop.UL
{
    internal class CoffeeShopUL
    {
        public static MenuItem getMenuItem()
        {
            string name;
            string type;
            float price;
            Console.Write("Enter name of item: ");
            name =Console.ReadLine();
            Console.Write("Enter type of item (food or drink ): ");
            type = Console.ReadLine();
            Console.Write("Enter price of item: ");
            price =float.Parse(Console.ReadLine());
            MenuItem newMenu=new MenuItem(name,type,price);
            return newMenu;
        }
        public static void viewCheapestItem(string iteam)
        {
            Console.WriteLine("Cheapest Item is "+iteam);
        }
        private static int d = 1;
        public static void viewDrinkMenu(List<string> drinkMenu)
        {
            Console.WriteLine("Dink Menu Items are...");
            foreach(string drink in drinkMenu)
            {
                Console.WriteLine(d + ". "+drink);
                d++;
            }
        }
        private static int f = 1;
        public static void viewFoodMenu(List<string> foodMenu)
        {
            Console.WriteLine("Food Menu Items are...");
            foreach (string food in foodMenu)
            {
                Console.WriteLine(f + ". " + food);
                f++;
            }
        }
        public static void viewShopMenu()
        {
            foreach (MenuItem m in CoffeeShopDL.menuList)
            {
                Console.WriteLine("Item Name : " + m.getMenuName());
                Console.WriteLine("Item Type : " + m.getMenuType());
                Console.WriteLine("Item Price : " + m.getMenuPrice());
                Console.WriteLine("------------------------------------");
            }
        }
        public static string getOrder()
        {
            CoffeeShop newOrder = new CoffeeShop();
            Console.WriteLine("Enter the name of order ");
            string orderName = Console.ReadLine();
            string message = newOrder.addOrder(orderName);
            Console.WriteLine(message);
            if(message== "The item is add sucessfully")
            {
                return orderName;
            }
            return null;
        }
      
        public static void viewFullFillOrder(string orderStatus)
        {
            Console.WriteLine("Full fill order are : "+orderStatus);
        }
        public static  void viewOrderList(List<string> storeOrderList)
        {
            foreach(string s in storeOrderList)
            {
                Console.WriteLine(s);
            }
        }
        public static void viewTotalPayableAmount(float payableAmount)
        {
            Console.WriteLine("Total Payable amount is " + payableAmount);
        }

    }
}
