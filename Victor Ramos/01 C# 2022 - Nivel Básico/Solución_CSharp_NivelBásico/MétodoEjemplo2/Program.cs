using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodoEjemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OperacionMatematica;
            int Noperacion;

            Console.WriteLine("Quieres realizar la tabla de Sumar o Multiplicar?");
            OperacionMatematica = Console.ReadLine();

            Console.WriteLine("Qué número de tabla desea que se muestre: ");
            Noperacion = int.Parse(Console.ReadLine());

            if(OperacionMatematica=="SUMAR")
            {
                Sumar(Noperacion);
            }
            else if (OperacionMatematica == "MULTIPLICAR")
            {
                Multiplicar(Noperacion);
            }
            else
            {
                Console.WriteLine("Operación matemática no válida");
            }

            Console.ReadKey();
        }

        //Método de la tabla de Sumar
        static void Sumar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " + " + a + " = " + (Numero + a));
            }

        }

        //Método de la tabla de Multiplicar
        static void Multiplicar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " X " + a + " = " + (Numero * a));
            }

        }
    }
}