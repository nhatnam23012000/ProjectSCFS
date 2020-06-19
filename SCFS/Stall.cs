using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class Stall
    {
        private int id;
        private String name;
        private LinkedList<Food> foods;
        public Stall()
        {
            id = 0;
            name = "";
            foods = new LinkedList<Food>();
        }
        public Stall(int id, String name, LinkedList<Food> foods)
        {
            this.id = id;
            this.name = name;
            this.foods = foods;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public int getID()
        {
            return id;
        }
        public void addFood(int id, String name, int price)
        {
            Food food = new Food(id, name, price);
            foods.AddLast(food);
        } 
        public Food getFood(int id)
        {
            for (int i = 0; i < foods.Count(); i++)
            {
                Food checkingFood = foods.ElementAt<Food>(i);
                if (checkingFood.id == id) return checkingFood;
            }
            return null;
        }
        public Food getFood(String name)
        {
            for (int i = 0; i < foods.Count(); i++)
            {
                Food checkingFood = foods.ElementAt<Food>(i);
                if (checkingFood.name == name) return checkingFood;
            }
            return null;
        }
        public void addReport(int id, String name, String date, long income, long outcome, ReportDatabase database)
        {
            database.addReport(id, name, date, income, outcome);
        }
        public Report getReport(String date, ReportDatabase database)
        {
            return database.getReport(date);
        }
        public LinkedList<Food> getFoodList()
        {
            return foods;
        }
    }
}
