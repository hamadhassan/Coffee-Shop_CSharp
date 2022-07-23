using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using Tesha_s_Coffee_Shop.DL;
namespace Tesha_s_Coffee_Shop.BL
{
    internal class CoffeeShop
    {
        private string nameShop;
        public void setCoffeeShopName(string nameShop)
        {
            this.nameShop = nameShop;
        }
        public string addOrder(string orderName)
        {
            string message = "";
            for (int i = 0; i < CoffeeShopDL.menuList.Count; i++)
            {
                if (CoffeeShopDL.menuList != null)
                {
                    if (orderName == CoffeeShopDL.menuList[i].getMenuName())
                    {
                        message = "The item is add sucessfully";
                    }
                    else
                    {
                        message = "The item is currently unavilable";
                    }
                }
                else
                {
                    message = "The item is currently unavilable";
                    break;
                }
            }
            return message;
        }
        public static string fullFillOrder()
        {
            string message = "";
            for (int i = 0; i < CoffeeShopDL.orders.Count; i++)
            {
                if (CoffeeShopDL.orders!= null)
                {
                    message = "The " + CoffeeShopDL.orders[i] + " is ready";
                    CoffeeShopDL.orders.Clear();
                    return message;
                }
            }
            return message = "All order have been fulfilled";
        }
        public static List<string> listOrders()
        {
            if (CoffeeShopDL.orders == null)
            {
                return null;
            }
            else
            {
                return CoffeeShopDL.orders;
            }
        }
        public static float dueAmount()
        {
            float payableAmount = 0;
            foreach(MenuItem m in CoffeeShopDL.menuList)
            {
                foreach(string o in CoffeeShopDL.orders)
                {
                    if (m.getMenuName() == o)
                    {
                        payableAmount += m.getMenuPrice();
                    }
                }
            }
            return payableAmount;
        }
        public static string cheapestItem()
        {
            float price =CoffeeShopDL.menuList[0].getMenuPrice();
            string iteamName= CoffeeShopDL.menuList[0].getMenuName();
            foreach(MenuItem m in CoffeeShopDL.menuList)
            {
                if(price > m.getMenuPrice())
                {
                    price = m.getMenuPrice();
                    iteamName = m.getMenuName();
                }
            }
            return iteamName;
        }
        public static List<string> drinkOnly()
        {
            List<string> drinkMenu = new List<string>();
            foreach(MenuItem m in CoffeeShopDL.menuList)
            {
                if(m.getMenuType() == "Drink"|| m.getMenuType() == "drink")
                {
                    drinkMenu.Add(m.getMenuName());
                }
            }
            return drinkMenu;
        }
        public static List<string> foodOnly()
        {
            List<string> foodMenu = new List<string>();
            foreach (MenuItem m in CoffeeShopDL.menuList)
            {
                if (m.getMenuType() == "Food"|| m.getMenuType() == "food")
                {
                    foodMenu.Add(m.getMenuName());
                }
            }
            return foodMenu;
        }
    }
}
