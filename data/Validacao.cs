using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Validacao
    {
        public static String validaemail()
        {
            string dado = string.Empty;
            do
            {
                dado = Console.ReadLine().Trim(); Console.Clear();
                if (dado.Equals("") || !dado.Contains('@') || !dado.EndsWith(".com"))
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("dado invalido! Digite um email que contenha '@' e '.com'!");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
            while (true);
            return dado;
        }
        public static String validastring()
        {
            string dado = String.Empty;
            do
            {
                dado = Console.ReadLine().Trim(); Console.Clear();
                if (dado.Equals(String.Empty))
                {
                    Console.Write("dado invalido: ");
                }
                else
                {
                    break;
                }
            }
            while (true);
            return dado;
        }
        public static String validastring(bool isname)
        {
            string dado = String.Empty;
            do
            {
                dado = Console.ReadLine().Trim(); Console.Clear();
                if (dado.Equals(String.Empty))
                {
                    Console.ForegroundColor = ConsoleColor.Red;Console.Write("dado invalido: ");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
            while (true);
            dado = dado.Substring(0, 1).ToUpper() + dado.Substring(1);
            return dado;
        }
        public static int validanumero()
        {
            int id = -1;
            while (id == -1)
            {
                try
                {
                    id = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("dado invalido! tente novamente!");
                    Console.ResetColor();
                }
            }
            return id;
        }
    }
}
