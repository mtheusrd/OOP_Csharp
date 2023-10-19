using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos_de_classes
{
    public class Carro
    {
        // MODIFICADOR_DE_ACESSO TIPO_DO_ATRIBUTO NOME_DO_ATRIBUTO
        // Modificadores
        // public e private

        // Criando atributo
        public string marca;
        private double velocidade;

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
            Carro meuCarro = new Carro();
            meuCarro.marca = "Honda";

        }
    }
}
