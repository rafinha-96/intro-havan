using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Usuario
    {
        //encapsulamento de proprieades
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set;}
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        //construtor

        public Usuario(string nome, string sobre, int id, string email, string cid, string rua, int num)
        {

            this.Nome = nome;
            this.SobreNome = sobre;
            this.Idade = id;
            this.Email = email;
            this.Cidade = cid;
            this.Rua = rua;
            this.Numero = num;

        }
        public Usuario()
        { 
            
        }

    }
}
