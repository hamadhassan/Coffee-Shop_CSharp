using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;
using Tesha_s_Coffee_Shop.UL;

namespace Tesha_s_Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coffeeShopPath = "coffeeShop.txt";
            string orderPath = "order.txt";
            string shopName=MiscUL.getCoffeeShopName();
            Console.Clear();
            CoffeeShopDL.readFromFileCoffeeShop(coffeeShopPath);
            CoffeeShopDL.readFromFileOrderList(orderPath);
            while (true)
            {
                MiscUL.header(shopName);
                char option = MiscUL.mainMenu();
                if (option == '1')
                {
                    MenuItem newMenu=CoffeeShopUL.getMenuItem();
                    CoffeeShopDL.setIntoMenuList(newMenu);
                    CoffeeShopDL.storeintoFileCoffeeShop(coffeeShopPath, newMenu);    
                }
                else if (option == '2')
                {
                    string itemName = CoffeeShop.cheapestItem();
                    CoffeeShopUL.viewCheapestItem(itemName);
                }
                else if (option == '3')
                {
                    List<string> drinkMenu = new List<string>();
                    drinkMenu = CoffeeShop.drinkOnly();
                    CoffeeShopUL.viewDrinkMenu(drinkMenu);
                }
                else if (option == '4')
                {
                    List<string> foodMenu = new List<string>();
                    foodMenu = CoffeeShop.foodOnly();
                    CoffeeShopUL.viewFoodMenu(foodMenu);
                }
                else if(option == '5')
                {
                    CoffeeShopUL.viewShopMenu();
                    string orderName=CoffeeShopUL.getOrder();
                    CoffeeShopDL.setIntoOrderList(orderName);
                    CoffeeShopDL.storeintoFileOrderList(orderPath, orderName);
                }
                else if (option == '6')
                {
                    string orderStatus = CoffeeShop.fullFillOrder();
                   CoffeeShopUL.viewFullFillOrder(orderStatus);
                }
                else if (option == '7')
                {
                    List<string> orderList = new List<string>();
                    orderList = CoffeeShop.listOrders();
                    CoffeeShopUL.viewOrderList(orderList);
                }
                else if (option == '8')
                {
                    float payableAmount = CoffeeShop.dueAmount();
                    CoffeeShopUL.viewTotalPayableAmount(payableAmount);
                }
                else if (option == '9')
                {
                    break;
                }
                MiscUL.clearScreen();
            }
        }
    }
}
