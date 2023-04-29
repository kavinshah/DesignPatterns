using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Dessert
    {
        private string name;
        private readonly IList<string> toppings;

        public string DessertName
        {
            get{ return name; }
        }

        public Dessert(string dessertName)
        {
            this.name = dessertName;
        }

        public void AddTopping(string topping)
        {
            this.toppings.Add(topping);
        }

        public string ListToppings()
        {
            return String.Join(",", toppings);
        }

    }
}
