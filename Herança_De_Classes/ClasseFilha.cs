using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_De_Classes
{
    internal class ClasseFilha: ClasseMae
    {
        public string atributoDaFilha = "Atributo da Filha";
        public string PropriedadeDaFilha
        {
            set;
            get;
        }
        public void MetodoDaClasseFilha()
        {
            MetodoDaClasseMae();
            Console.WriteLine("Método da classe filha");
        }
        public ClasseFilha():base("aaaaaa") // parametros da outra classe
        {
            PropriedadeDaFilha = "Propriedade da Filha";
        }
    }
}
