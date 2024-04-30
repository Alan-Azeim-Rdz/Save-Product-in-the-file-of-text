using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_to_exel
{
    internal class ItemForContainer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int quantity;
        public int Quantity 
        { 
            get { return quantity; }
            set { quantity = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public ItemForContainer()
        {
            name = "";
            quantity = 0;
            price = 0;
        }

        public ItemForContainer(string names , int quantitys, int prices)
        {
            name = names;
            quantity = quantitys;
            price = prices;
        }

        public override string ToString()
        {
            return name + " - " + quantity + " - " + price;
        }
    }
}
