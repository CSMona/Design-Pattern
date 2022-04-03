using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }
        public Pizza orderPizza(String type)
        {
            Pizza pizza;
            pizza = factory.createPizza(type);
            return pizza;
        }
    }
}
