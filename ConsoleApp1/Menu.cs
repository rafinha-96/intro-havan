using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class Menu
    {
        List<usuario> usuarios = new List<usuario>();

        public void montamenu()
        {
            cabecalho();
            opcoes();
            rodape();          
            escolha();
            Console.ReadLine();
        }

        public void mostrarusuarios(List<usuario> usuarios)
        {
            if(usuarios.Count<= 0 )
            {
                Console.WriteLine("\nnenhum usuario cadastrado!");           
            }
            else
            {
                foreach (var item in usuarios)
                {
                    Console.WriteLine($"usuario -\nnome completo: {item.nome}{ item.sobre}\nidade: { item.id}\nemail: { item.email}\ncidade: { item.cid}\nrua: { item.rua} , numero: { item.num}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\npress enter para voltar ao menu: ");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            montamenu();
        }
        private void cabecalho()
        {
            Console.WriteLine("*********************  bem vindo  *************************");
            Console.WriteLine("********************* havan labs  *************************");
        }


        private void opcoes()
        {
            Console.WriteLine("opções: ");
            Console.WriteLine("1 - cadastro usuário");
            Console.WriteLine("2 - cadastro produto");
            Console.WriteLine("3 - mostrar usuarios");
            Console.WriteLine("0 - sair");
        }

        private void rodape()
        {
            Console.Write("Escolha uma opção: ");
        }
        

        public void escolha()
        {
            int opcao= 0;
            do
            {
                opcao = Validacao.validanumero();
                switch (opcao)
                {
                    
                    case 0:
                        Console.WriteLine("thau");
                        break;
                    case 1:
                        
                        Console.Clear();
                        string resposta = "";
                        do
                        {
                            usuario user = new usuario();
                            user.cadastro();
                            Console.WriteLine("deseja cadatrar mais um usuario? s/n");
                            resposta = Console.ReadLine();
                            usuarios.Add(user);
                        }
                        while (resposta=="s");                                           
                        Console.Clear();
                        montamenu();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("produto em andamento!");
                        Console.Write("press enter para voltar ao menu!");
                        Console.ReadLine();Console.Clear();                       
                        montamenu();
                        break;
                    case 3:
                        mostrarusuarios(usuarios);
                        Console.WriteLine("press enter para sair para o menu! ");
                        Console.ReadLine();
                        Console.Clear();
                        montamenu();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("opção inválida");
                        Console.ResetColor();
                        break;
                }
            }
            while (opcao < 0 || opcao > 3);
        }
    }
}
