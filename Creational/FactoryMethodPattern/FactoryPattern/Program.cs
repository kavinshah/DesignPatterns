// See https://aka.ms/new-console-template for more information
using FactoryPattern;
using System.Net.Http.Headers;


//we need to use the appropriate constructor to initiate the process of producing dinosaur noise.
DinosaurNoiseProducerFactory factory1 = new SagasaurusNoiseProducerFactory();
factory1.MakeDinosaurNoise();

DinosaurNoiseProducerFactory factory2 = new TrexNoiseProducerFactory();
factory2.MakeDinosaurNoise();

DinosaurNoiseProducerFactory factory3 = new RandomNoiseProducerFactory();
factory3.MakeDinosaurNoise();