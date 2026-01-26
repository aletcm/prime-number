using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj0006 {
   internal class Program {
      static void Main() {
         Console.ForegroundColor = ConsoleColor.DarkCyan;
         Console.WriteLine("**********************************************************************");
         Console.WriteLine("                      Checador de Números Primos                      ");
         Console.WriteLine("**********************************************************************\n");
         Console.ResetColor();

      start:
         Console.Write("Digite um número inteiro válido ou \"sair\" para interromper: ");
         string input = Console.ReadLine();
         bool proceed = int.TryParse(input, out int number);

         if (input.ToLower() == "sair") {
            Console.WriteLine();
            return;
         } else {
            if (!proceed || number < 1) {
               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Console.WriteLine("\nENTRADA INVÁLIDA! Tente novamente.");
               Console.ResetColor();
               goto start;
            } else {
               bool prime = IsPrime(number);
               if (prime) {
                  Console.ForegroundColor = ConsoleColor.DarkGreen;
                  Console.WriteLine($"\nO número {number} é primo!");
                  Console.ResetColor();
                  goto start;
               } else {
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine($"\nO número {number} não é primo!");
                  Console.ResetColor();
                  goto start;
               }
            }
         }
      }
      private static bool IsPrime(int n) {
         if (n <= 1) return false;
         if (n == 2) return true;
         if (n % 2 == 0) return false;

         long limit = (long)Math.Sqrt(n);
         for (long i = 3; i <= limit; i += 2) {
            if (n % i == 0) return false;
         }

         return true;
      }
   }
}
