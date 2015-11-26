using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class Meat : Food
    {
        float protein;
        float iron;
        float vitaminB12;
        public string name;
        public string foodType;
        public Meat()
        {
            name = "Meat";
            foodType = "Meat";
        }
    }
}
