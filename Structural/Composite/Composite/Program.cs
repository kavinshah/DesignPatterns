// See https://aka.ms/new-console-template for more information

using Composite;

IDepartment financialDepartment = new FinancialDepartment("financial", 2);
IDepartment salesDepartment = new SalesDepartment("sales", 2);

HeadDepartment headDepartment = new HeadDepartment();
headDepartment.AddChild(financialDepartment);
headDepartment.AddChild(salesDepartment);

headDepartment.PrintDepartmentName();


