using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    internal class Diretor : Funcionario
    {

        public override double GetBonificacao()
        {
            return this.Salario + 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public Diretor(string cpf) :base( cpf, 5000)
        {

        }
    }
}
