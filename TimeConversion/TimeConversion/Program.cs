using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, resto, valor;

            Console.WriteLine("Insira o numero para conversão: ");

            valor = int.Parse(Console.ReadLine());

            horas = valor / 3600;
            resto = valor % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}