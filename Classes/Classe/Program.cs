using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriandoClasses;

//MODIFICADOR_DE_ACESSO class NOME_DA_CLASSE { }

// Modificadores de acesso
// internal (interno) - só pode ser acessada pelo nosso assembly
// public (público) - o uso dessa classe é livre.
// private (privado) - a classe só poderá ser acessada iternamente ao bloco de código que a criou.

namespace Classe
{
    internal class Carro_Internal
    {
        Carro_Public meuCarroPublic = new Carro_Public();
    }

    public class Carro_Public
    {
        Carro_Internal meuCarroInternal = new Carro_Internal();
    }
    
    internal class Program
    {
        private class Carro_Private
        {

        }
        static void Main(string[] args)
        {
            //NOME_DA_CLASSE NOME_DO_OBJETO = new NOME_DA_CLASSE(PARAMETROS);
            Carro_Internal meuCarroInternal = new Carro_Internal();
            Carro_Public meuCarroPublic = new Carro_Public();
            Carro_Private meuCarroPrivate = new Carro_Private();
            CarroExterno meuCarroExterno = new CarroExterno();

        }
    }
}
