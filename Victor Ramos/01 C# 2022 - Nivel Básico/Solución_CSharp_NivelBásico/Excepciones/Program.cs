using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            try
            {
                Console.Write("Ingresa tu edad: ");
                Edad = int.Parse(Console.ReadLine()); //Controla el error si ingresas un string

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }             

            Console.ReadKey();
        }
    }
}
