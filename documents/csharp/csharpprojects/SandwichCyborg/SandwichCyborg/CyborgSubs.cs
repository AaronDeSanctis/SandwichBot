using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class CyborgSubs
    {
        public SandwichCyborg Al;
        public List<Customer> customers;
        public List<string> foodTypeMenu;
        public List<string> meatMenu;
        public List<string> drinkMenu;
        public List<string> dairyMenu;
        public List<string> veggieMenu;
        public List<string> sauceMenu;
        public List<string> breadMenu;
        public List<Object> FinalSandwich;
        public CyborgSubs()
        {
            foodTypeMenu = new List<string>(new string[] {"Dairy", "Bread", "Drink", "Sauce", "Veggie", "Meat"});
            meatMenu = new List<string>(new string[] { "Salami", "Ham", "Roast Beef", "Turkey", "Bacon"});
            drinkMenu = new List<string>(new string[] { "Coke", "Mountain Dew", "Milk", "Orange Juice", "Coffee", "Gatorade"});
            dairyMenu = new List<string>(new string[] { "Shredded Cheddar", "Provolone", "Cheddar Jack", "Colby Jack"});
            veggieMenu = new List<string>(new string[] { "Olives", "Lettuce", "Spinach", "Pickles"});
            sauceMenu = new List<string>(new string[] { "Chipotle Mayo", "Mayo"});
            breadMenu = new List<string>(new string[] { "Seven Grain Wheat Bread", "Wheat Bread", "Italian", "Tortilla"});
            Al = new SandwichCyborg();
            FinalSandwich = new List<Object>();
            customers = new List<Customer>();
        }
        public void OpenShop(int custAmount)
        {
            for (int i = 0; i <= custAmount; i++)
            {
                AddToCustomers();
            }
            RunShop();
        }
        public void AddToCustomers()
        {
            Customer cust = new Customer();
            customers.Add(cust);
        }
        public void RunShop()
        {
            foreach (Customer customer in customers)
            {
                List<string> foodType = customer.ChooseFoodType(foodTypeMenu);
                customer.ChooseFood(foodType, meatMenu, drinkMenu, sauceMenu, breadMenu, dairyMenu, veggieMenu);
                List<string> SandwichOrder = customer.GetSandwichOrder();
                Al.ComputeSandwich(SandwichOrder);
                Al.GiveSandwichInfo();
                FinalSandwich = Al.GiveSandwich();
                customer.EatSandwich(FinalSandwich);
            }
            CloseShop();
        }


        public void CloseShop()
        {
            Console.WriteLine("All Done.");
        }
    }
}
