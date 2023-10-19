using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_de_classes
{

        public class Carro
    {
        // Atributos
        public string marca;
        private double velocidade;

        //Propriedades
        //MODIFICADOR_DE_ACESSO TIPO NOME
        //{
        //  get{ return ATRIBUTO; } - É utilizado para retornar o conteúdo do nosso atributo
        //  set{ ATRIBUTO = value; } - É utilizado para alterar o conteúdo do nosso atributo
        //}

        public void ConfiguraVelocidade(double VelocidadeFinal)
        {
            velocidade = VelocidadeFinal;
            marca = "Fiat";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
