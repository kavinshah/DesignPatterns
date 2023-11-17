using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IStrategy
    {
        int PerformOperation(int a, int b);
    }

    internal class Context
    {
        IStrategy strategy;
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int Execute(int a , int b)
        {
            return strategy.PerformOperation(a, b);
        }
    }

    internal class StrategyAdd : IStrategy
    {
        public int PerformOperation(int a, int b)
        {
            int result;
            result = a + b;
            return result;
        }
    }

    internal class StrategySubtract : IStrategy
    {
        public int PerformOperation(int a, int b)
        {
            int result;
            result = a - b;
            return result;
        }
    }

    internal class StrategyMultiply : IStrategy
    {
        public int PerformOperation(int a, int b)
        {
            int result;
            result = a * b;
            return result;
        }
    }

}
