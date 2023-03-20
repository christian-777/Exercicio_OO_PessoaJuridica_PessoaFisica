using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OO_PessoaJuridica_PessoaFisica
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public override string ToString()
        {
            return ("\nNome: " + this.Name + "\nEndereco: " + this.Adress + "\nEmail: " + this.Email + "\nPrimeiro Telefone: " + this.Phone1 + "\nSegundo Telefone: " + this.Phone2);
        }
    }
}
