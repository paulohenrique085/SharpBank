using BancoSharp.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSharp.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel autentico,string senhaTentativa) {
            bool usuarioAutenticado = autentico.Autenticar(senhaTentativa);
            
            if (usuarioAutenticado==true)
            {
                Console.WriteLine("Bem-vindo ao sistema interno");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário inválido");
                return false;
            }
            
        }
    }
}
