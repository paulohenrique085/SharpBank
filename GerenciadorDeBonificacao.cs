using BancoSharp.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp
{
    class GerenciadorDeBonificacao
    {
        private double _totalDeBonus { get; set; }

        //exemplo de polimorfismo
        public void RegistroDeBonus(Funcionario funcionario) {
            _totalDeBonus += funcionario.GetBonificacao();
        }

        public double GetTotalDeBonus()
        {
            return _totalDeBonus;
        }
    }
}
