// See https://aka.ms/new-console-template for more information

using Facade;

bool meteor = false;

while (!meteor)
{
    DinoEcosystemFacade facade = new DinoEcosystemFacade(new Soil(1));
    facade.RunGeneration();
    Console.WriteLine("Has a Meteor hit? Y/N?");
    var readkey = Console.ReadKey();
    meteor = readkey.KeyChar == 'Y';
}

Console.WriteLine("Meteor has hit and destroyed the ecosystem");
