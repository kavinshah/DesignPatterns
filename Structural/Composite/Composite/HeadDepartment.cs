using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class HeadDepartment : IDepartment
    {
        private int id;
        private string name;
        private List<IDepartment> childDepartments=new List<IDepartment>();

        public void PrintDepartmentName()
        {
            foreach (IDepartment d in childDepartments)
            {
                d.PrintDepartmentName();
            }
        }

        public void AddChild(IDepartment child)
        {
            childDepartments.Add(child);
        }

        public void RemoveChild(IDepartment child)
        {
            childDepartments.Remove(child);
        }

    }
}
