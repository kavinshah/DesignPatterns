using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /*
     * 1. We define an abstract class that defined the algorithm to prepare any beverage
     * 2. The template method defines all the steps to prepare the beverage
     * 3. Brew() and AddCondiments() are 2 methods that every beverage needs to re-define
     */
    internal abstract class CaffeineBeverage
    {
        // template method to prepare any beverage
        public void PrepareCaffeine()
        {
            BoilWater();
            Brew();
            AddCondiments();
            PourInCup();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring in a cup");
        }

        //step to be re-defined
        public abstract void Brew();

        //step to be re-defined
        public abstract void AddCondiments();

    }

    internal class Tea : CaffeineBeverage
    {
        public Tea()
        {
            Console.WriteLine("Preparing Tea");
        }

        //step specific to tea subclasss
        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk to Tea");
        }

        //step specific to tea subclasss
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }

    internal class Coffee : CaffeineBeverage
    {
        public Coffee()
        {
            Console.WriteLine("Preparing Coffee");
        }

        //step specific to coffee subclasss
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon to coffee");
        }

        //step specific to coffee subclasss
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
