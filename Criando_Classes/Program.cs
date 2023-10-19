using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MODIFICADOR_DE_ACESSO class NOME_DA_CLASSE {}
// Modificadores de acesso:
// internal - só pode ser acessada pelo assembly
// public - O uso da nossa classe é livre
// private - só poderá ser acessada internamente pelo bloco de codigo que a criou


namespace Criando_Classes
{

    internal class Carro_Internal
    {

    }
    
    public class Carro_Public
    {

    }
    internal class Program
    {
        // só podemos criar classes privadas dentro de outras classes
        private class Carro_Private
        {

        }
        static void Main(string[] args)
        {
            // OBJETO = INSTÂNCIA
            //NOME_DA_CLASSE NOME_DO_OBJETO = new NOME_DA_CLASSE(PARAMETROS);

            Carro_Internal meuCarroInternal = new Carro_Internal();
            Carro_Public meuCarroPublic = new Carro_Public();
            Carro_Private meuCarroPrivate = new Carro_Private();
            CarroExterno meuCarroExterno = new CarroExterno();

        }
    }
}
