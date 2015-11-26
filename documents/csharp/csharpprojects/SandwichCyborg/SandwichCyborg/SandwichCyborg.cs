using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class SandwichCyborg
    {
        public string input;
        public List<object> FinalSandwich;
        FoodSelection foodSelect;
        public bool Complete;
        public SandwichCyborg()
        {
            FinalSandwich = new List<object>();
        }

        public void ComputeSandwich(List<string> customerOrders)
        {
            foodSelect = new FoodSelection();
            foreach (string order in customerOrders)
            {
                object FoodItem = foodSelect.FindItem(order);
                FinalSandwich.Add(FoodItem);
            }
        }
        public void GiveSandwichInfo()
        {
            foreach (object item in FinalSandwich)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
        public List<object> GiveSandwich()
        {
            return FinalSandwich;
        }
    }
}
