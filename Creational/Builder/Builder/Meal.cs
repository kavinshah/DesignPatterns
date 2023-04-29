using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Meal
    {
        public string starter;
        public string maincourse;
        public Dessert dessert;

        public Meal()
        {
        }

        public void SetDessert(string dessertName)
        {
            dessert = new Dessert(dessertName);
        }

        public void AddTopping(string toppingName)
        {
            dessert.AddTopping(toppingName);
        }

        public void ServeMeal()
        {
            Console.WriteLine($"Serving {starter} then {maincourse} with {dessert.DessertName} and {dessert.ListToppings()} toppings");
        }
    }
}
