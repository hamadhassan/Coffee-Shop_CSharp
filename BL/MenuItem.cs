using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tesha_s_Coffee_Shop.BL
{
    internal class MenuItem
    {
        private string name;
        private string type;
        private float price;

        public MenuItem(string name,string type,float price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public string getMenuName()
        {
            return name;
        }
        public string getMenuType()
        {
            return type;
        }
        public float getMenuPrice()
        {
            return price;
        }
    }
}
