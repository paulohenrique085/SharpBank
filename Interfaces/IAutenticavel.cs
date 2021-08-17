using BancoSharp.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp.Sistemas
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
    }
}
