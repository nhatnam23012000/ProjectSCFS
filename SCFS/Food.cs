using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class Food
    {
        public int id;
        public String name;
        public int price;
        public int amount;
        public Food()
        {
            this.id = 0;
            this.name = "";
            this.price = 0;
            this.amount = 0;
        }
        public Food(int id, String name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = 0;
        }
        public Food(int id, String name, int price, int amount)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = amount;
        }
    }
}
