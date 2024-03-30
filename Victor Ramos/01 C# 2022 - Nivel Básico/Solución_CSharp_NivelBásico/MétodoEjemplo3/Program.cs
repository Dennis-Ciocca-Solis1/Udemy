using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodoEjemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Dias;
            double PagoxDia;

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Cuánto te pagan por día trabajado?: ");
            PagoxDia = double.Parse(Console.ReadLine());

            Console.Write("Cuántos días trabajaste?: ");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por los días trabajados es: " + CalcularTotal(PagoxDia,Dias));

            Console.ReadKey();

        }

        //Método para obtener el total de dinero ganado por trabajo
        static double CalcularTotal(double Dinero, int NroDias) //CalcularTotal(dineroGanado, díasTrabajados)
        {           
            double Total;

            Total = (Dinero * NroDias);

            return Total;
        }



    }
}
