// See https://aka.ms/new-console-template for more information
using AbstractFactory;

DinosaurNoiseProducer.GetInstance().MakeADinosaurNoise(new DinosaurFactory("TRex"));
DinosaurNoiseProducer.GetInstance().MakeADinosaurNoise(new DinosaurFactory("Stegosaurus"));
DinosaurNoiseProducer.GetInstance().MakeADinosaurNoise(new RandomDinosaurFactory(new Random()));
//NewDinosaurNoiseProducer.GetInstance();

/*
 example of subclassing a singleton class.
 */
class A
{
    private A instance;
    protected A()
    {
    }

    public virtual A GetInstance()
    {
        if (instance == null)
        {
            instance = new A();
        }
        return instance;
    }
}

class B: A
{
    private B instance;
    protected B()
    {
    }

    public override B GetInstance()
    {
        if (instance == null)
        {
            instance = new B();
        }
        return instance;
    }
}