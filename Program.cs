using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Document[] documents = new Document[2];
            //documents[0] = new Resume();
            //documents[1] = new Report();

            //foreach (var document in documents)
            //{
            //    Console.WriteLine("\n" + document.GetType().Name + "--");
            //    foreach (Page page in document.Pages)
            //    {
            //        Console.WriteLine(" " + page.GetType().Name);
            //    }
            //}
            // Wait for user

            var tmp = new ConcretRobotFreeRdpOption();

            tmp.FactoryMethod("Bundle");

            tmp.FactoryMethod("Seperate");

            Console.ReadKey();
        }
    }
}
