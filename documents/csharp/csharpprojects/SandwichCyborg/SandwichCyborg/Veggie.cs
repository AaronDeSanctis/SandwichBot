using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class Veggie : Food
    {
        public string foodType;
        public string name;
        float potassium;
        float dietaryFiber;
        float folate;
        float vitaminA;
        float vitaminC;
        public Veggie()
        {
            name = "Veggie";
            foodType = "Veggie";
        }
    }
}
