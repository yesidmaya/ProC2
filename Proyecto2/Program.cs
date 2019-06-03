using System;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
                
            Console.WriteLine("INTRODUZCA VALORES A SUMAR");

            Console.WriteLine("introduzca el PRIMER valor: ");
            int a = Convert.ToInt32(Console.ReadLine()); // convertimos el valor a entero cuando lo agreguemos por consola

            Console.WriteLine("Introduzca el SEGUNDO valor a sumar: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            resultado = a + b;

            // <,>,<=,>=,==,!= // menor que,mayor que, menor igual, mayor igual, igual, diferente

            Console.WriteLine("La suma es:" + resultado.ToString());

            if (resultado < 10)
            {
                Console.WriteLine("El resultado es MENOR que 10");
            }
            else if (resultado > 10)
            {
                Console.WriteLine("El resultado es MAYOR que 10");
            }
            else {
                Console.WriteLine("el valor es igual a 10");
            }
            
            Console.WriteLine("Pulse un tecla para finalizar");
            Console.ReadLine();
        }
    }
}
