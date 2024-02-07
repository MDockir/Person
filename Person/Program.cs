using Person.Math;

namespace Person
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var mads = new person();
            mads.FirstName = "Mads";
            mads.LastName = "Dockir";
            mads.Introduse();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);


        }
    }
}