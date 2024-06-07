namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage coffee = new Coffee();
            coffee.PrepareCaffeine();

            CaffeineBeverage tea = new Tea();
            tea.PrepareCaffeine();
        }
    }
}
