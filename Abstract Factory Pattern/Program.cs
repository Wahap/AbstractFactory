using Abstract_Factory_Pattern.Concrete_Factorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker checker = new PhoneTypeChecker(MANUFACTURERS.SAMSUNG);

            checker.CheckProducts();

            Console.ReadLine();


            checker = new PhoneTypeChecker(MANUFACTURERS.NOKIA);

            checker.CheckProducts();
            Console.Read();
        }
    }
}
