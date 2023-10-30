using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class FinancialDepartment : IDepartment
    {
        private string name;
        private int id;

        public FinancialDepartment(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void PrintDepartmentName()
        {
            Console.WriteLine(this.GetType().Name);
        }


    }
}
