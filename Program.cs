using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR26
{
    class Program
    {
        static void Main(string[] args)
        {
            Car avto = new avto();
            avto.Model = "BMW";
            avto.Year = 888;
            Console.WriteLine(avto);

            Car avto1 = new Car("Audi", 1990);
            Car avto2 = new Car("BMW", 2007);
            Car avto3 = new Car("Nisan", 2000);
            Car avto4 = new Car("Chevrolet Camaro", 1996);
            Car avto5 = new Car("Lexus", 1999);
            Console.WriteLine($"Марка {avto.Model} Год Производства {avto1.Year}");
            Console.WriteLine($"Марка {avto.Model} Год Производства {avto2.Year}");
            Console.WriteLine($"Марка {avto.Model} Год Производства {avto3.Year}");
            Console.WriteLine($"Марка {avto.Model} Год Производства {avto4.Year}");
            Console.WriteLine($"Марка {avto.Model} Год Производства {avto5.Year}");
            Console.ReadKey();
        }
    }
}
