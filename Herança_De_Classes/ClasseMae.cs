using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_De_Classes
{

    // Modificadores de acesso
    //public - todo mundo tem acesso (classes filhas e externamente)
    //private - somente à propria classe tem acesso (nem as filhas nem externamente é possivel acessar)
    //protected - somente poderá ser acessado pela classe filha e pela propria classe (externamente não poderá ser acessado)

    internal class ClasseMae
    {
        public string atributoDaMae = "Atributo da Mãe";
        public string PropriedadeDaMae
        {
            set;
            get;
        }

        public void MetodoDaClasseMae()
        {
            Console.WriteLine("Método da classe mãe");
        }
        public ClasseMae(string pPropriedadeDaMae)
        {
            PropriedadeDaMae = pPropriedadeDaMae;
        }
    }
}
