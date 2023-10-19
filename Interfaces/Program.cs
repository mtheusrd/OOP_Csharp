using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface é um protótipo de uma classe (esqueleto/contrato)
//Ela define os métodos que serão implementados pela Classe.

namespace Interfaces
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.AbrirPorta();
            meuCarro.FecharPorta();
            meuCarro.Ligar();
            meuCarro.Desligar();
            meuCarro.Acelerar();    

            Aviao meuAviao = new Aviao();
            meuAviao.AbrirPorta();
            meuAviao.FecharPorta();
            meuAviao.Ligar();
            meuAviao.Desligar();
            meuAviao.Decolar();

            IVeiculo meuVeiculoCarro = new Carro();
            meuCarro.AbrirPorta();
            meuCarro.FecharPorta();
            meuCarro.Ligar();
            meuCarro.Desligar();


            IVeiculo meuVeiculoAviao = new Aviao();
            meuAviao.AbrirPorta();
            meuAviao.FecharPorta();
            meuAviao.Ligar();
            meuAviao.Desligar();
        }
    }
}
