using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_classes // funções
{
    public class ContaBancaria
    {

        //atributos
        private double saldo;
        private string senha;
        private string nomeDoCliente;


        // Métodos ou Funções
        // MODIFICADOR_DE_ACESSO TIPO_DE_SAIDA NOME_DO_METODO(TIPO_PAR1 NOME_PAR1,TIPO_PAR2 NOME_PAR2...)
        //{
        // CONTEÚDO_DO_MÉTODO
        // return VALOR_DE_SAÍDA
        //}

        //MODIFICADOR_DE_ACESSO
        //public e private

        // TIPO_DE_SAÌDA
        // Ex: int, string, bool, class, List...

        // PARAMETROS_DE_ENTRADA
        // TIPO_PAR: int, string, class, List...
        // NOME_PAR: qualquer nome

        public double Sacar(double pValorSacado, string pSenha)
        {
            if (senha == pSenha)
            {
                if(saldo > pValorSacado)
                {
                    saldo -= pValorSacado;
                    Console.WriteLine("O Valor sacado foi de: " + pValorSacado);
                    return pValorSacado;
                }
                else
                {
                    Console.WriteLine("O saldo é insuficiente");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("A senha está incorreta");
                return 0;
            }
        }

        public void Depositar(double pValorDepositado)
        {
            saldo += pValorDepositado;
            Console.WriteLine("O Valor depositado foi de: "+ pValorDepositado);
        }

        public void ConsultaSaldo(string pSenha)
        {
            if (senha == pSenha)
            {
                Console.WriteLine("O saldo da conta é: " + saldo);
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
        }
        public ContaBancaria(string pSenha, string pNomeDoCliente) // método construtor
            // primeiro metodo a ser executado quando (instanciamos a classe) / (criamos um objeto)
            // Construtor nao possui parâmetro de saída
            // O construtor é sempre publico
            // Normalmente o construtor é usado para fazer as configurações iniciais do nosso objeto
        {
            saldo = 0;
            senha = pSenha;
            nomeDoCliente = pNomeDoCliente;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaDoPedro = new ContaBancaria("12345", "PedroSantos");
            
            double valorSacado = contaDoPedro.Sacar(10, "12345");
            contaDoPedro.Depositar(1000);
            contaDoPedro.ConsultaSaldo("12345");
            valorSacado = contaDoPedro.Sacar(10, "12345");

            Console.ReadKey();
        }
    }
}
