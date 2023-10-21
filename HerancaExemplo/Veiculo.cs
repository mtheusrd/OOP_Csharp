using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo 
{
    internal class Veiculo // Tudo que é comum em todos os veiculos
    {
        //Atributos
        private uint numeroRodas;
        private uint numeroPortas;
        private uint velocidade;
        private bool estaLigado;

        // Propriedas para alterar os atributos
        public uint NumeroRodas
        {
            get { return numeroRodas;}
        }
        public uint NumeroPortas
        {
            get { return numeroPortas;}
        }
        public uint Velocidade
        {
            get { return velocidade;}
            set { velocidade = value;}
        }
        public bool EstaLigado
        {
            get { return estaLigado;}
        }

        //Metodos
        public void Ligar()
        {
            Console.WriteLine("Veículo ligado");
        }
        public void Desligar()
        {
            Console.WriteLine("Veículo desligado");
        }

        //Construtor da classe Veiculo
        
        public Veiculo(uint pNumeroRodas, uint pNumeroPortas)
        {
            this.numeroRodas = pNumeroRodas;
            this.numeroPortas = pNumeroPortas;
            velocidade = 0;
            estaLigado = false;
        }
    }
}
