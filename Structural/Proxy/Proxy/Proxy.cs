using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal interface INest
    {
        void Access(string name);
    }

    internal class RealNest: INest
    {
        public void Access(string name)
        {
            Console.WriteLine($"{name} has access to the nest");
        }
    }

    internal class SecureNestProxy : INest
    {
        INest nest;
        public SecureNestProxy(INest nest)
        {
            this.nest = nest;
        }

        public void Access(string name)
        {
            if(name.Equals("TRex") || name.Equals("Giganotosaurus"))
            {
                throw new UnauthorizedAccessException($"{name} is not allowed to access the nest.");
            }

            nest?.Access(name);
        }
    }


    internal class Proxy
    {

    }
}
