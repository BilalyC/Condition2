using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veillez taper votre âge :");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
            else
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
        }
    }
}
