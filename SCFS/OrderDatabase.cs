using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class OrderDatabase
    {
        private LinkedList<Order> orders;
        private int count;
        public OrderDatabase()
        {
            orders = new LinkedList<Order>();
            count = 0;
        }
        public void addOrder(Order order)
        {
            orders.AddLast(order);
            order.setState(State.WAITING);
            count++;
        }
        public Order getOrder(String name)
        {
            for (int i = 0; i < orders.Count(); i++)
            {
                Order order = orders.ElementAt<Order>(i);
                if (order.getName() == name) return order;
            }
            return null;
        }
        public void removeOrder(String name)
        {
            for (int i = 0; i < orders.Count(); i++)
            {
                Order removeOrder = orders.ElementAt<Order>(i);
                if (removeOrder.getName() == name)
                {
                    orders.Remove(removeOrder);
                    count--;
                }
            }
        }
        public Order getOrderList(int i)
        {
            return orders.ElementAt<Order>(i);
        }
        public int getCount()
        {
            return count;
        }
    }
}
