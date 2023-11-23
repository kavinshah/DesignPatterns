using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal abstract class MealBuilder
    {
        protected Meal meal;

        public Meal Meal
        {
            get
            {
                return meal ?? BuildMeal();
            }
        }

        public Meal BuildMeal()
        {
            meal = new Meal();
            AddStarter();
            AddMain();
            AddDessert();
            AddToppings();
            return meal;
        }

        protected abstract void AddStarter();
        protected abstract void AddMain();
        protected abstract void AddDessert();
        protected abstract void AddToppings();
    }

}
