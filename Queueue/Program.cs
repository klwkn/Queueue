using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Jojo");
            patients.Enqueue("Tobi Lou");
            patients.Enqueue("EDP445");
            Console.WriteLine();
            foreach (var patient in patients)
            {
                Console.WriteLine("\n" + patient);
            }

            patients.Dequeue();
            Console.WriteLine("\nfirst has been removed...");
            foreach (var patient in patients)
            {
                Console.WriteLine("\n" + patient);
            }
            Console.WriteLine("\nHere is the first person: " + patients.Peek());
            Console.ReadKey();
        }
    }
}
