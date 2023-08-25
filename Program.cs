using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            Console.WriteLine("Ingrese 5 números para ordenar:");

            for (int i = 0; i < 5; i++)
            {
                int input;
                do
                {
                    Console.Write($"Número {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out input))
                    {
                        numbers.Push(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Ingrese un número válido.");
                    }
                } while (true);
            }

            // Crear una nueva pila para el ordenamiento
            Stack<int> sortedStack = new Stack<int>();

            while (numbers.Count > 0)
            {
                int currentNumber = numbers.Pop();

                // Insertar el número en el lugar correcto en la pila ordenada
                while (sortedStack.Count > 0 && sortedStack.Peek() > currentNumber)
                {
                    numbers.Push(sortedStack.Pop());
                }

                sortedStack.Push(currentNumber);
            }

            Console.WriteLine("Pila ordenada de mayor a menor:");
            foreach (int num in sortedStack)
            {
                Console.Write(num + " ");
                Console.ReadLine();
            }
        }
    }
}
