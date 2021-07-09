using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void kjh()
            {

            Console.Write("digite seu nome: ");
            string nome = Console.ReadLine();
            int id = 0;
            while (id == 0)
            {
                try
                {
                    Console.Write("digite sua idade: ");
                    id = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("dado invalido! digite novamente. ");
                }

            }
            //int id = int.Parse(Console.ReadLine());
            if (id >= 18)
            Console.WriteLine($"ola {nome} você tem {id} anos! você é de maior");
            else
            Console.WriteLine($"ola {nome} você tem {id} anos! você é de menor!");


            Console.ReadLine();


            }
    }
}
