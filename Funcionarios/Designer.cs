using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf) : base( 3000,cpf)
        {
            Console.WriteLine("CRIANDO DESIGNER");
        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario() {
            Salario = Salario + (Salario * 0.11);
        }

       
    }
}
 