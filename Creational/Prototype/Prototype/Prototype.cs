using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    public class Color : ColorPrototype
    {
        int red, green, blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override string ToString()
        {
            return "Red:" + this.red
                + "\nGreen:" + this.green
                + "\nBlue:" + this.blue;
        }
        public override ColorPrototype Clone()
        {
            return MemberwiseClone() as ColorPrototype;
        }
    }

    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype> ();

        public ColorPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }
    }
}
