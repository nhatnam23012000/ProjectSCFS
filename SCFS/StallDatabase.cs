using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class StallDatabase
    {
        private int count;
        private LinkedList<Stall> stalls;
        public StallDatabase()
        {
            stalls = new LinkedList<Stall>();
            count = 0;
        }
        public bool addStall(int id, String name, LinkedList<Food> foods)
        {
            for (int i = 0; i < stalls.Count(); i++)
            {
                Stall checkingStall = stalls.ElementAt<Stall>(i);
                if (checkingStall.getName() == name)
                {
                    return false;
                }
            }
            Stall newStall = new Stall(id, name, foods);
            stalls.AddLast(newStall);
            count++;
            return true;
        }
        public bool removeStall(int id)
        {
            for (int i = 0; i < stalls.Count(); i++)
            {
                Stall checkingStall = stalls.ElementAt<Stall>(i);
                if (checkingStall.getID() == id)
                {
                    stalls.Remove(checkingStall);
                    count--;
                    return true;
                }
            }
            return false;
        }
        public Stall searchStall(int id)
        {
            for (int i = 0; i < stalls.Count(); i++)
            {
                Stall checkingStall = stalls.ElementAt<Stall>(i);
                if (checkingStall.getID() == id)
                {
                    return checkingStall;
                }
            }
            return null;
        }
        public Stall searchStall(String name)
        {
            for (int i = 0; i < stalls.Count(); i++)
            {
                Stall checkingStall = stalls.ElementAt<Stall>(i);
                if (checkingStall.getName() == name)
                {
                    return checkingStall;
                }
            }
            return null;
        }
        public void addFood(int id, int foodID, String name, int cost)
        {
            this.searchStall(id).addFood(foodID, name, cost);
        }
        public int getCount()
        {
            return count;
        }
        public Stall getStall(int i)
        {
            return stalls.ElementAt<Stall>(i);
        }
    }
}
