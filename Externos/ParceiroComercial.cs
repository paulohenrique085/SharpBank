using BancoSharp.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp
{
    class ParceiroComercial : IAutenticavel
    {
       
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
