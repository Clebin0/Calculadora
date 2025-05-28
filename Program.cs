using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Calculadora Simples ===");

            while (true)
            {
                Console.Write("Digite o primeiro número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Número inválido! Tente novamente.");
                    continue;
                }

                Console.Write("Digite o operador (+, -, *, /): ");
                string operador = Console.ReadLine();

                Console.Write("Digite o segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Número inválido! Tente novamente.");
                    continue;
                }

                double resultado;

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
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                            continue;
                        }
                        resultado = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Operador inválido! Use +, -, * ou /.");
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado}\n");

                Console.Write("Deseja fazer outra operação? (s/n): ");
                string resposta = Console.ReadLine()?.ToLower() ?? "n";

                if (resposta != "s")
                    break;
            }

            Console.WriteLine("Obrigado por usar a calculadora!");
        }
    }
}
