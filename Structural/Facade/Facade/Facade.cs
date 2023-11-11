using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Soil
    {
        int nutrientsCount;
        public Soil(int nutrientsCount)
        {
            this.nutrientsCount = nutrientsCount;
        }

        public void AddNutrient(Edible edible)
        {
            edible.Eat();
            nutrientsCount++;
            Console.WriteLine($"Nutrient Count: {nutrientsCount}");
        }

        public void UseNutrient()
        {
            if(nutrientsCount <= 0)
            {
                throw new Exception("No more nutrients left in the soil");
            }
            nutrientsCount--;
            Console.WriteLine($"Nutrient Count: {nutrientsCount}");
        }
    }

    internal abstract class Edible
    {
        public bool isEaten;
        
        public void Eat()
        {
            if(isEaten)
            {
                throw new Exception("Already Eaten");
            }
            isEaten = true;
        }
    }

    internal class Plant : Edible
    {
        public Plant(Soil soil)
        {
            Console.WriteLine("A new plant grows");
            soil.UseNutrient();
            this.isEaten = false;
        }
    }

    internal class Herbivore : Edible
    {
        public Herbivore(Edible plant)
        {
            Console.WriteLine("The herbivore eats a plant");
            plant.Eat();
            isEaten = false;
        }
    }

    internal class Carnivore : Edible 
    {
        public Carnivore(Edible Herbivore)
        {
            Console.WriteLine("A carnivore eats the herbivore");
            Herbivore.Eat();
            isEaten = false;
        }

        public void Die(Soil soil)
        {
            Console.WriteLine("The carnivore dies");
            soil.AddNutrient(this);
        }
    }

    /*
     * This is called the facade.
     * We hide the complexity behind a class.
     * The calling code does not need to know the complexity of running the ecosystem.
     */
    internal class DinoEcosystemFacade
    {
        Soil soil;

        public DinoEcosystemFacade(Soil soil)
        {
            this.soil = soil;
        }

        public void RunGeneration()
        {
            var plant = new Plant(soil);
            var herbivore = new Herbivore(plant);
            var carnivore = new Carnivore(herbivore);
            carnivore.Die(soil);
        }
    }
}
