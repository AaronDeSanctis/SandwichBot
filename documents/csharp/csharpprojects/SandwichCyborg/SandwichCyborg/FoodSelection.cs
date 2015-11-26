using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichCyborg
{
    public class FoodSelection
    {
        public object FindItem(string order)
        {
            if (order == "Shredded Cheddar")
            {
                ShreddedCheddar shredChed = new ShreddedCheddar();
                return shredChed;
            }
            else if (order == "Provolone")
            {
                Provolone prov = new Provolone();
                return prov;
            }
            else if (order == "Cheddar Jack")
            {
                CheddarJack chedJack = new CheddarJack();
                return chedJack;
            }
            else if (order == "Colby Jack")
            {
                ColbyJack colbyJack = new ColbyJack();
                return colbyJack;
            }
            else if (order == "Seven Grain Wheat Bread")
            {
                SevenGrainWheatBread sevenWheat = new SevenGrainWheatBread();
                return sevenWheat;

            }
            else if (order == "Wheat Bread")
            {
                WheatBread wheat = new WheatBread();
                return wheat;
            }
            else if (order == "Italian")
            {
                Italian italian = new Italian();
                return italian;
            }
            else if (order == "Tortilla")
            {
                Tortilla tortilla = new Tortilla();
                return tortilla;
            }
            else if (order == "Coke")
            {
                Coke coke = new Coke();
                return coke;
            }
            else if (order == "Mountain Dew")
            {
                MountainDew mtnDew = new MountainDew();
                return mtnDew;
            }
            else if (order == "Milk")
            {
                Milk milk = new Milk();
                return milk;
            }
            else if (order == "Orange Juice")
            {
                OrangeJuice OJ = new OrangeJuice();
                return OJ;
            }
            else if (order == "Coffee")
            {
                Coffee coffee = new Coffee();
                return coffee;
            }
            else if (order == "Gatorade")
            {
                Gatorade gatorade = new Gatorade();
                return gatorade;
            }
            else if (order == "Ham")
            {
                Ham ham = new Ham();
                return ham;
            }
            else if (order == "Turkey")
            {
                Turkey turkey = new Turkey();
                return turkey;
            }
            else if (order == "Roast Beef")
            {
                RoastBeef beef = new RoastBeef();
                return beef;
            }
            else if (order == "Salami")
            {
                Salami salami = new Salami();
                return salami;
            }
            else if (order == "Bacon")
            {
                Bacon bacon = new Bacon();
                return bacon;
            }
            else if (order == "Mayo")
            {
                Mayo mayo = new Mayo();
                return mayo;
            }
            else if (order == "Chipotle Mayo")
            {
                ChipotleMayo chipMayo = new ChipotleMayo();
                return chipMayo;
            }
            else if (order == "Olives")
            {
                Olives olives = new Olives();
                return olives;
            }
            else if (order == "Lettuce")
            {
                Lettuce lettuce = new Lettuce();
                return lettuce;
            }
            else if (order == "Spinach")
            {
                Spinach spinach = new Spinach();
                return spinach;
            }
            else if (order == "Pickles")
            {
                Pickles pickles = new Pickles();
                return pickles;
            }
            else
            {
                Ham ham = new Ham();
                return ham;
            }
        }
    }
}
