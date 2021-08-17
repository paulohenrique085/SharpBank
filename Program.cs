using BancoSharp.Sistemas;
using System;

namespace BancoSharp.Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("hello world");
            //LogarSistema();


        }
        
        public static void LogarSistema()
        {
            Diretor leonardo = new Diretor("440.531.693-72","12345");
            ParceiroComercial alex = new ParceiroComercial();
            alex.Senha = "5555";
            
            
            
            SistemaInterno itau = new SistemaInterno();
            
            itau.Logar(leonardo,"12345");
            itau.Logar(alex, "5555");
            
            
        }
        /*public static void CalcularBonificação()
        {
            GerenciadorDeBonificacao gerenciadorDeBonificacao = new GerenciadorDeBonificacao();

            Designer pedro = new Designer("332.445.369.-89");
            pedro.Nome = "Pedro Carvalho";

            Diretor roberta = new Diretor("633.455.963.73");
            roberta.Nome = "Roberta Abrantes";

            Auxiliar igor = new Auxiliar("396.485.996.45");
            pedro.Nome = "Igor Macambira";

            GerenteDeConta camila = new GerenteDeConta("369.987.364.-94");
            camila.Nome = "Camila Teles";

            gerenciadorDeBonificacao.RegistroDeBonus(pedro);
            gerenciadorDeBonificacao.RegistroDeBonus(roberta);
            gerenciadorDeBonificacao.RegistroDeBonus(igor);
            gerenciadorDeBonificacao.RegistroDeBonus(camila);

            Console.WriteLine("Total de bonificação: " + gerenciadorDeBonificacao.GetTotalDeBonus());
        }*/
    }
}
