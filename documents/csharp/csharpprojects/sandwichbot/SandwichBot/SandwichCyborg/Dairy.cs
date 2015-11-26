using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SandwichCyborg
{
    public class Dairy : Food
    {
        float calcium;
        float carbohydrates;
        float vitaminD;
        float protein;
        float potassium;
        public string name;
        public string foodType;
        public Dairy()
        {
            name = "Dairy";
            foodType = "Dairy";
        }
    }
}
