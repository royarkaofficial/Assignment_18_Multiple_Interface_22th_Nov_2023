using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_Multiple_Inheritance_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            Smartphone myPhone = new Smartphone("iPhone");
            Laptop myLaptop = new Laptop("Dell");

            // Demonstrate usage of interfaces
            myPhone.Connect();
            myPhone.Charge(30);
            Console.WriteLine(myPhone.Display());

            Console.WriteLine();

            myLaptop.Connect();
            myLaptop.Charge(45);
            Console.WriteLine(myLaptop.Display());
        }
    }
}
