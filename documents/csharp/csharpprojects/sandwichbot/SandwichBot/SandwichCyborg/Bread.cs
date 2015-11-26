using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class Bread : Food
    {
        float carbohydrate;
        float protein;
        float solubleDietaryFiber;
        float insolubleDietaryFiber;
        float grain;
        public string name;
        public string foodType;
        public Bread()
        {
            name = "Bread";
            foodType = "Bread";
        }
    }
}
