using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    public enum DinosaurType
    {
        TRex,
        Stegosaurus
    }

    public interface IDinosaur
    {
        public void MakeANoise();
    }

    public interface IDinosaurFactory
    {
        public IDinosaur CreateADinosaur();
    }

    public interface IDinosaurNoiseProducer
    {
        public void MakeADinosaurNoise();
    }

    public class TRex : IDinosaur
    {
        public void MakeANoise()
        {
            Console.WriteLine("Making TRex Noise!!");
        }
    }

    public class Stegosaurus : IDinosaur
    {
        public void MakeANoise()
        {
            Console.WriteLine("Making Stegosaurus Noise!!");
        }
    }

    public class DinosaurFactory : IDinosaurFactory
    {
        private readonly DinosaurType dinosaurType;

        public DinosaurFactory(string dinosaurName)
        {
            Enum.TryParse(dinosaurName, true, out this.dinosaurType);
        }

        public IDinosaur CreateADinosaur()
        {
            IDinosaur dinosaur=null;

            Console.WriteLine("Using Dinosaur Factory");

            switch (dinosaurType)
            {
                case DinosaurType.TRex:
                    dinosaur = new TRex();
                    break;
                case DinosaurType.Stegosaurus:
                    dinosaur = new Stegosaurus();
                    break;
                default:
                    dinosaur = new TRex();
                    break;
            }
            return dinosaur;
        }
    }

    public class RandomDinosaurFactory : IDinosaurFactory
    {
        private Random random;
        public IDinosaur dinosaur;
        public RandomDinosaurFactory(Random random)
        {
            this.random = random;
        }

        public IDinosaur CreateADinosaur()
        {
            int randomNumber = random.Next(0, 10);

            Console.WriteLine("Using Random Dinosaur Factory");

            if (randomNumber < 5)
            {
                dinosaur = new TRex();
            }
            else
            {
                dinosaur = new Stegosaurus();
            }
            return dinosaur;
        }
    }

    public class DinosaurNoiseProducer : IDinosaurNoiseProducer
    {
        private IDinosaurFactory dinosaurFactory;

        public DinosaurNoiseProducer(IDinosaurFactory dinosaurFactory)
        {
            this.dinosaurFactory = dinosaurFactory;
        }

        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = dinosaurFactory.CreateADinosaur();
            dinosaur.MakeANoise();
        }
    }
}
