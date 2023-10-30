using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class SalesDepartment : IDepartment
    {
        private string name;
        private int id;

        public SalesDepartment(string name, int id)
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
