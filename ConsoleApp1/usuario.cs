using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class usuario
    {
        public string nome = string.Empty;
        public string sobre = string.Empty;
        public int id = 0;
        public string email = string.Empty;
        public string cid = string.Empty;
        public string rua = string.Empty;
        public int num = 0;
        
        public void cadastro()
        {
            
            Console.Write("digite seu primeiro nome: ");
            this.nome = Validacao.validastring(true); Console.Clear();

            Console.Write("digite seu sobrenome: ");
            this.sobre = Validacao.validastring(true); Console.Clear();

            Console.Write("digite sua idade: ");
            this.id = Validacao.validanumero(); Console.Clear();

            Console.Write("digite seu email: ");
            this.email = Validacao.validaemail(); Console.Clear();

            Console.Write("cidade: ");
            this.cid = Validacao.validastring(); Console.Clear();

            Console.WriteLine("digite o nome da sua Rua: ");
            this.rua = Validacao.validastring(); Console.Clear();

            Console.WriteLine("digite o numero da sua casa: ");
            this.num = Validacao.validanumero();Console.Clear();

            Console.WriteLine($"\nnome completo: {this.nome} {this.sobre}\nidade: {this.id}\nemail: {this.email}\ncidade: {this.cid}\nrua: {this.rua} , numero: {this.num}");
            Console.WriteLine("\ncadastro realizado com sucesso!\n" +
                "press enter para voltar ao menu anterior!");
            Console.ReadLine(); 
           
        }
        


    }
}
