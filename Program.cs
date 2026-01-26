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
         Console.WriteLine("*                     Checador de Números Primos                     *");
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
            if (!proceed | number < 1) {
               Console.WriteLine("\nENTRADA INVÁLIDA!");
               goto start;
            } else {
               bool prime = IsPrime(number);
               if (prime) {
                  Console.WriteLine($"\nO NÚMERO {number} É PRIMO!");
                  goto start;
               } else {
                  Console.WriteLine($"\nO NÚMERO {number} NÃO É PRIMO!");
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
