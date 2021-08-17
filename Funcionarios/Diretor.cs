using BancoSharp.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;


namespace BancoSharp.Funcionarios
{
    class Diretor : FuncionarioAutenticavel 
    {

        
        public Diretor(string cpf,string senha) : base( 5000, cpf )
        {
            Senha = senha;
        }  
        


        public override double GetBonificacao()
        {
            return Salario * 0.5   ;
        }
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.15);
        }
        
       
    }
}
