﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    internal class GerenteDeContas : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario + 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }
    }
}
