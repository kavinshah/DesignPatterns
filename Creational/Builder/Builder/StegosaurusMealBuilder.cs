using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class StegosaurusMealBuilder : MealBuilder
    {
        protected override void AddDessert()
        {
            this.meal.SetDessert("fruit and berries");
        }

        protected override void AddMain()
        {
            this.meal.maincourse="a huge plate of ferns";
        }

        protected override void AddStarter()
        {
            this.meal.starter = "a few green leaves";
        }

        protected override void AddToppings()
        {
            this.meal.AddTopping("crunchy flowers");
        }
    }
}
