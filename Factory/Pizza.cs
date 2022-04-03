using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Pizza
    {
        public void prepare()
        {
            Console.WriteLine("prepare");
        }
        public void bake()
        {
            Console.WriteLine("bake");
        }
        public void cut()
        {
            Console.WriteLine("cut");
        }
        public void box()
        {
            Console.WriteLine("box");
        }

        Pizza orderPizza(String type)
        {
            Pizza pizza = null;
    
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }


    }
  
    
    }
