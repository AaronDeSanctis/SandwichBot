using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class Sauce : Food
    {
        public string name;
        public string foodType;
        float saturatedFat;
        float sodium;
        float sugar;
        float carbohydrates;
        public Sauce()
        {
            name = "Sauce";
            foodType = "Sauce";
        }
    }
}
