using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IGigantosaurus
    {
        string Roar();
    }

    public class Gigantosaurus : IGigantosaurus
    {
        public string Roar()
        {
            return "ROAR";
        }
    }

    public class LoudGigantosaurus : IGigantosaurus 
    {
        IGigantosaurus gigantosaurus;
        public LoudGigantosaurus(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }
        public string Roar()
        {
            return gigantosaurus.Roar() + " Loudly";
        }
    }

    public class VeryLoudGigantosaurus : IGigantosaurus
    {
        IGigantosaurus gigantosaurus;
        public VeryLoudGigantosaurus(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return gigantosaurus.Roar() + " !!!!";
        }
    }

    public class SilentGigantosaurus : IGigantosaurus
    {
        IGigantosaurus gigantosaurus;
        public SilentGigantosaurus(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus= gigantosaurus;
        }

        public string Roar()
        {
            return "This gigantosaurus does not Roar";
        }
    }

}
