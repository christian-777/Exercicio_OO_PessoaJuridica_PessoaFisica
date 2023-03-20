using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OO_PessoaJuridica_PessoaFisica
{
    internal class PhysicalPerson : Person
    {
        public string Cpf { get; set; }

        public override string ToString()
        {
            return (base.ToString()+"\nCpf: "+this.Cpf);
        }
    }
}
