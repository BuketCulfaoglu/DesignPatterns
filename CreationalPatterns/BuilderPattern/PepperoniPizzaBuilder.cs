using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough()
        {
            _pizza.Dough = "thick crust";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "tomato";
        }

        public void BuildTopping()
        {
            _pizza.Topping = "pepperoni slices";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
