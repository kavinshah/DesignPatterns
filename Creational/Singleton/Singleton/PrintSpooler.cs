using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal abstract class PrintSpooler<T> where T : class, new()
    {
        private static T? _instance=null;
        private static object _lock = new object();
        public PrintSpooler()
        {
        }

        public static T GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                }
            }
            return _instance;
        }
    }

    internal class PrintSpoolerWithColorPrinting : PrintSpooler<ColorPrinting>
    {
        private static PrintSpoolerWithColorPrinting? _instance=null;
        private static object _lock = new object();
        private PrintSpoolerWithColorPrinting()
        {
            return;
        }
        public static new PrintSpoolerWithColorPrinting GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PrintSpoolerWithColorPrinting();
                    }
                }
            }
            return _instance;
        }
    }

    internal class PrintSpoolerWithoutColorPrinting : PrintSpooler<Printing>
    {
        private static PrintSpoolerWithoutColorPrinting? _instance = null;
        private static object _lock = new object();
        private PrintSpoolerWithoutColorPrinting()
        {
            return;
        }
        public static new PrintSpoolerWithoutColorPrinting GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PrintSpoolerWithoutColorPrinting();
                    }
                }
            }
            return _instance;
        }
    }

    internal class ColorPrinting
    {
        //TODO
    }

    internal class Printing
    {
        //TODO
    }
}
