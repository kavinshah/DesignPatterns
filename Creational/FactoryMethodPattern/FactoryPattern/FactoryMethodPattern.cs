using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Dinosaur
    {
        /// <summary>
        /// Provides a default implementation for MakeNoise().
        /// We are marking it as virtual so that subclasss can
        /// override and provide their own implementation for it.
        /// ** Please be noted that this method should be marked
        /// ** as virtual to allow for overriding (dynamic polymorphism)
        /// </summary>
        public virtual void MakeNoise()
        {
            Console.WriteLine("Making Generic Dinosaur Noise!");
        }
    }

    public class Trex : Dinosaur
    {
        /// <summary>
        /// This is not necessary and we can use default implementation
        /// for makenoise() in its abstract class Dinosaur.
        /// However, if we want a new noise for each concrete product
        /// i.e. trex dinosaur, then we need to override
        /// ** Please be noted that this method should be marked as override
        /// ** to let the CLR know that we need to use this subclass method
        /// ** instead of Dinosaur.MakeNoise() method.
        /// </summary>
        public override void MakeNoise()
        {
            Console.WriteLine("Making Trex Noise!");
        }
    }

    public class Segasaurus : Dinosaur
    {
        /// <summary>
        /// This is not necessary and we can use default implementation
        /// for makenoise() in abstract class.
        /// However, if we want a new noise for each concrete product
        /// i.e. segasaurus dinosaur, then we need to override
        /// ** Please be noted that this method should be marked as override
        /// ** to let the CLR know that we need to use this subclass method
        /// ** instead of Dinosaur.MakeNoise() method.
        /// </summary>
        public override void MakeNoise()
        {
            Console.WriteLine("Making Sagasaurus Noise!");
        }
    }

    public abstract class DinosaurNoiseProducerFactory
    {
        private Dinosaur dinosaur;

        /// <summary>
        /// We are providing a default implementation for MakeDinosaurNoise()
        /// This allows any subclass to override it if required.
        /// A subclass can continue to use default implementation
        /// if applicable.
        /// </summary>
        public virtual void MakeDinosaurNoise()
        {
            dinosaur = CreateDinosaur();
            dinosaur?.MakeNoise(); // using null conditional operator prevents runtime exception.
            Console.WriteLine($"Type:{dinosaur?.GetType()}"); // using null conditional operator prevents runtime exception.
        }

        /// <summary>
        /// This is the factory method
        /// The method is declared as an abstract method.
        /// This will allow subclass to provide a concrete implementation.
        /// </summary>
        /// <returns>It returns a concrete object of type Dinosaur</returns>
        public abstract Dinosaur CreateDinosaur();
    }

    public class TrexNoiseProducerFactory : DinosaurNoiseProducerFactory
    {
        /// <summary>
        /// This is the factory method which is being overidden by subclass
        /// providing a concrete implementation 
        /// to create appropriate dinosaur  object
        /// </summary>
        /// <returns></returns>
        public override Dinosaur CreateDinosaur()
        {
            return new Trex();
        }
    }

    public class SagasaurusNoiseProducerFactory : DinosaurNoiseProducerFactory
    {
        /// <summary>
        /// This is the factory method which is being overidden by subclass
        /// providing a concrete implementation 
        /// to create appropriate dinosaur  object
        /// </summary>
        /// <returns></returns>
        public override Dinosaur CreateDinosaur()
        {
            return new Segasaurus();
        }
    }

    public class RandomNoiseProducerFactory : DinosaurNoiseProducerFactory
    {
        // over here we are returning null for dinosaur.
        // we are handling cases for null values in abstract dinosaur factory
        public override Dinosaur CreateDinosaur()
        {
            return null;
        }
    }
}
