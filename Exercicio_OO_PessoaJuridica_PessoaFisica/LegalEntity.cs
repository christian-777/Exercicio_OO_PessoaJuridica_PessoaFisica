using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OO_PessoaJuridica_PessoaFisica
{
    internal class LegalEntity : Person
    {
        public string Cnpj { get; set; }
        public string FantasyName { get; set; }

        public override string ToString()
        {
            return ("\nNome Fantasia: " + this.FantasyName+base.ToString()+"\nCnpj: "+this.Cnpj);
        }
    }
}
