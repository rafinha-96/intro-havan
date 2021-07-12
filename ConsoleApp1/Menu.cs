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
        List<Usuario> usuarios = new List<Usuario>();

        public void montamenu()
        {
            cabecalho();
            opcoes();
            rodape();          
            escolha();
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
                            Console.Write("digite seu primeiro nome: ");
                            string nome = Validacao.validastring(true); Console.Clear();

                            Console.Write("digite seu sobrenome: ");
                            string sobre = Validacao.validastring(true); Console.Clear();

                            Console.Write("digite sua idade: ");
                            int id = Validacao.validanumero(); Console.Clear();

                            Console.Write("digite seu email: ");
                            string email = Validacao.validaemail(); Console.Clear();

                            Console.Write("cidade: ");
                            string cid = Validacao.validastring(); Console.Clear();

                            Console.WriteLine("digite o nome da sua Rua: ");
                            string rua = Validacao.validastring(); Console.Clear();

                            Console.WriteLine("digite o numero da sua casa: ");
                            int num = Validacao.validanumero(); Console.Clear();
                            //cria variavel com dados
                            Usuario user = new Usuario(nome, sobre, id, email, cid, rua, num);
                            //guarda os dados na variavel
                            usuarios.Add(user);

                            Console.WriteLine("deseja cadatrar mais um usuario? s/n");
                            resposta = Console.ReadLine();
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
                        Console.Clear();
                        mostrarusuarios(usuarios);                                    
                        Console.Clear();
                        montamenu();
                        break;
                    default:
                        Console.WriteLine("opção inválida");  
                        break;
                }
            }
            while (opcao < 0 || opcao > 3);
        }

        public void mostrarusuarios(List<Usuario> usuarios)
        {
            if(usuarios.Count<= 0 )
            {
                Console.WriteLine("\nnenhum usuario cadastrado!");           
            }
            else
            {
                foreach (var item in usuarios)
                {
                    Console.WriteLine($"usuario -\nnome completo: {item.Nome}{ item.SobreNome}\nidade: { item.Idade}\nemail: { item.Email}\ncidade: { item.Cidade}\nrua: { item.Rua} , numero: { item.Numero}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\npress enter para voltar ao menu: ");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
