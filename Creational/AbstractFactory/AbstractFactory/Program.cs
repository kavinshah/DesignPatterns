// See https://aka.ms/new-console-template for more information
using AbstractFactory;


IDinosaurNoiseProducer af1 = new AbstractFactory.DinosaurNoiseProducer(new DinosaurFactory("TRex"));
af1.MakeADinosaurNoise();

IDinosaurNoiseProducer af2 = new AbstractFactory.DinosaurNoiseProducer(new DinosaurFactory("Stegosaurus"));
af2.MakeADinosaurNoise();

af2 = new AbstractFactory.DinosaurNoiseProducer(new RandomDinosaurFactory(new Random()));
af2.MakeADinosaurNoise();



