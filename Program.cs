using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador,numero,tabuada;
            contador = 0;

            Console.Write("Exiba o número:");
            numero = Convert.ToInt32(Console.ReadLine());

            while(contador <= 10)
            {
                tabuada = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {tabuada}");
                contador = contador +1;
            }
        }
    }
}
