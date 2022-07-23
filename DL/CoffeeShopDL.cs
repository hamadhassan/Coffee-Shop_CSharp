using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesha_s_Coffee_Shop.BL;
using System.IO;
namespace Tesha_s_Coffee_Shop.DL
{
    internal class CoffeeShopDL
    {
        static public List<MenuItem> menuList = new List<MenuItem>();
        static public List<string> orders = new List<string>();
        static public void setIntoMenuList(MenuItem storeConsoleInput)
        {
            menuList.Add(storeConsoleInput);
        }
        static public void setIntoOrderList(string storeConsoleInput)
        {
            orders.Add(storeConsoleInput);
        }
        public static void storeintoFileCoffeeShop(string path, MenuItem m)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(m.getMenuName() +"," + m.getMenuType() + "," + m.getMenuPrice() );
            f.Flush();
            f.Close();
        }
        public static void readFromFileCoffeeShop(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name=splittedRecord[0];
                    string type=splittedRecord[1];
                    float price=float.Parse(splittedRecord[2]);
                    MenuItem addItem=new MenuItem(name, type, price);
                    setIntoMenuList(addItem);
                }
                f.Close();
            }
        }
        public static void storeintoFileOrderList(string path, string orderName)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(orderName);
            f.Flush();
            f.Close();
        }
        public static void readFromFileOrderList(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string order = splittedRecord[0];
                    setIntoOrderList(order);
                }
                f.Close();
            }
        }

    }
}
