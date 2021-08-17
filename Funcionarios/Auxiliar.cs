using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar( string cpf) : base(2000, cpf)
        {
            Console.WriteLine("CRIANDO AUXILIAR");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.10);
        }

       
    }
}
