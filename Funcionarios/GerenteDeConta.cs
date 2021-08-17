using BancoSharp.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta( string cpf) : base(4000, cpf)
        {
            Console.WriteLine("CRIANDO GERENTE DE CONTA");
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.5);
        }

        
    }
}
