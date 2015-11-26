using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SandwichCyborg
{
    public class Customer
    {
        public bool orderComplete;
        private Random randInt;
        public List<string> sandwichOrder;
        public List<string> FoodTypeItems;
        public Customer()
        {
            orderComplete = false;
            randInt = new Random();
            sandwichOrder = new List<string>();
            FoodTypeItems = new List<string>();
        }
        public bool isOrderComplete()
        {
            return orderComplete;
        }
        public void EatSandwich(List<Object> Sandwich)
        {
            foreach(Object food in Sandwich)
            {
                Console.WriteLine("eats ");
            }
        }
        public List<string> ChooseFoodType(List<string> FoodTypeMenu)
        {
            foreach (string item in FoodTypeMenu)
            {
                int deliciousness = randInt.Next(0, 150);
                if (deliciousness >= 130)
                {
                    FoodTypeItems.Add(item);
                    FoodTypeItems.Add(item);
                    FoodTypeItems.Add(item);
                }
                else if (deliciousness >= 110)
                {
                    FoodTypeItems.Add(item);
                    FoodTypeItems.Add(item);
                }
                else if (deliciousness >= 75)
                {
                    FoodTypeItems.Add(item);
                }
                
            }
            return FoodTypeItems;
        }
        public void ChooseFood(List<string> FoodTypeItems, List<string> MeatMenu, List<string> DrinkMenu, List<string> SauceMenu, List<string> BreadMenu, List<string> DairyMenu, List<string> VeggieMenu)
        {
            foreach(string typeItem in FoodTypeItems)
            {
                if (typeItem == "Meat")
                {
                    ChooseItem(MeatMenu);
                }
                else if (typeItem == "Veggie")
                {
                    ChooseItem(VeggieMenu);
                }
                else if (typeItem == "Dairy")
                {
                    ChooseItem(DairyMenu);
                }
                else if (typeItem == "Bread")
                {
                    ChooseItem(BreadMenu);
                }
                else if (typeItem == "Drink")
                {
                    ChooseItem(DrinkMenu);
                }
                else if (typeItem == "Sauce")
                {
                    ChooseItem(SauceMenu);
                }
            }
        }

        private void ChooseItem(List<string> Menu)
        {
            foreach (string item in Menu)
            {
                int deliciousness = randInt.Next(0, 150);
                if (deliciousness >= 130)
                {
                    sandwichOrder.Add(item);
                    sandwichOrder.Add(item);
                    sandwichOrder.Add(item);
                }
                else if (deliciousness >= 110)
                {
                    sandwichOrder.Add(item);
                    sandwichOrder.Add(item);
                }
                else if (deliciousness >= 75)
                {
                    sandwichOrder.Add(item);
                }

            }
        }
        public List<string> GetSandwichOrder()
        {
            return sandwichOrder;
        }
    }
}
