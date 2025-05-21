using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09.Models
{
    /*
        Define um contrato que qualquer classe que deseje ser
        "locável"  preia seguir
     */
    public interface ILocavel //Interface não implementa método
    {
        string Titulo { get; }

        public bool EstaDisponivel { get; set; }
        public void Alugar();
        public void Devolver();
    }
}
