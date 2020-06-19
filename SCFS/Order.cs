using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class Order
    {
        private String customerName;
        private State state;
        private int cost;
        private LinkedList<Food> foods;
        public Order(String name)
        {
            this.customerName = name;
            this.state = State.NOEXIST;
            this.cost = 0;
            this.foods = new LinkedList<Food>();    
        }
        public void setName(String name)
        {
            this.customerName = name;
        }
        public String getName()
        {
            return customerName;
        }
        public void setState(State state)
        {
            this.state = state;
        }
        public State getState()
        {
            return state;
        }
        public void orderFood(int id, int stallID, int count, StallDatabase database)
        {
            Food food = database.searchStall(stallID).getFood(id);
            food.amount = count;
            foods.AddLast(food);
            this.cost += food.price*count;
        }
        public void removeFood(int i)
        {
            cost -= foods.ElementAt<Food>(i).price * foods.ElementAt<Food>(i).amount;
            foods.Remove(foods.ElementAt<Food>(i));             
        }
        public void removeFood(String name)
        {
            for (int i = 0; i < foods.Count(); i++)
            {
                Food removeFood = foods.ElementAt<Food>(i);
                if (removeFood.name == name)
                {
                    foods.Remove(removeFood);
                }
            }
        }
        public LinkedList<Food> getFoodList()
        {
            return foods;
        }
        public void setCost()
        {
            this.cost = 0;
        }
        public int getCost()
        {
            return cost;
        }
    }

}
