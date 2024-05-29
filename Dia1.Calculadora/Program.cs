using System;
using System.Collections.Generic;

namespace Dia1.Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> historico = new List<string>();

            Console.Clear();

            while (true)
            {
                Console.WriteLine("Digite um número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite um operador (+, -, *, /):");
                string operador = Console.ReadLine();

                Console.WriteLine("Digite outro número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;

                    case "-":
                        resultado = num1 - num2;
                        break;

                    case "*":
                        resultado = num1 * num2;
                        break;

                    case "/":
                        resultado = num1 / num2;
                        break;
                }

                Console.WriteLine($"O resultado é {resultado}");

                historico.Add($"{num1} {operador} {num2} = {resultado}");

                Console.WriteLine("Deseja continuar? (s/n)");
                string continuar = Console.ReadLine();
                if (continuar.ToLower() != "s")
                {
                    Console.WriteLine($"Histórico: {historico.Count} operações realizadas");
                    break;
                }
            }
        }
    }
}
