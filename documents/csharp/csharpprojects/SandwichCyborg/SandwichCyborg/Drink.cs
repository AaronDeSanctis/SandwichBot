using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class Drink : Food
    {
        float calcium;
        float vitaminC;
        float ginseng;
        float potassium;
        public string name;
        public string foodType;
        public Drink()
        {
            name = "Drink";
            foodType = "Drink";
        }
    }
}
