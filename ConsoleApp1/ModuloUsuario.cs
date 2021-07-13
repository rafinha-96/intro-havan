using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class ModuloUsuario
        
    {
        UsuarioRepositorio repository = new UsuarioRepositorio();
        public void Create()
        {
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
                Usuario model = new Usuario(nome, sobre, id, email, cid, rua, num);
                //guarda os dados na variavel
                repository.Create(model);
                Console.WriteLine("deseja cadatrar mais um usuario? s/n");
                resposta = Console.ReadLine();
            }
            while (resposta == "s");
        }
    }
}
