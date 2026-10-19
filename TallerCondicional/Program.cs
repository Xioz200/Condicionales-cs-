
using System;

class Program
{
    static string CheckNumber(int numero)
    {
        if (numero > 0)
        {
            return "El número es positivo";
        }
        else if (numero < 0)
        {
            return "El número es negativo";
        }
        else
        {
            return "El número es cero";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== TALLER DE CONTROL CONDICIONAL ===");
        Console.Write("Ingrese un número entero: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string resultado = CheckNumber(numero);
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Error: debe ingresar un número entero válido.");
        }

        Console.WriteLine("\nPresione una tecla para finalizar.");
        Console.ReadKey();
    }
}
