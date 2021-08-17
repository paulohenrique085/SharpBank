﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp.Funcionarios
{
    public abstract class Funcionario
    {        
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get;  protected set; }

        public  Funcionario( double salario,string cpf)
        {
            Salario = salario;
            CPF = cpf;
        }
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}
