using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar datos
            Console.WriteLine("Ingresa la edad del ganador: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("=============================================");
            Console.WriteLine("Ingrese la cantidad de adivinazas acertadas: ");
            int adivinanzas_acertadas = int.Parse(Console.ReadLine());
            double monto_inicial = 0;

            //Definir variables
            if (edad >= 18) 
            {
                if (adivinanzas_acertadas < 3) 
                {
                    monto_inicial = 30.00;
                }
                else 
                {
                    monto_inicial = 50.00;
                }
            }
            else
            {
                if (adivinanzas_acertadas < 3)
                {
                    monto_inicial = 50.00;
                }
                else 
                {
                    monto_inicial = 80.00;
                }
            }
            double monto_extra = (edad * 5.00) + (adivinanzas_acertadas * 2.00);
            double monto_final = monto_inicial + monto_extra;

            //Mostrar resultado
            Console.WriteLine("=============================================");
            Console.WriteLine($"El monto final del ganador es: S/. {monto_final}");
            Console.ReadKey();
        }
    }
}
