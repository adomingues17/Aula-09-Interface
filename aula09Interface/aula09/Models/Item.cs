using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09.Models
{
    public abstract class Item : ILocavel //indica que Item IMPLEMENTA ILocavel
    {
        public string Titulo { get; set; }

        public bool EstaDisponivel { get; set; } = true;
        public virtual void Alugar() {
            EstaDisponivel = false;        
        }

        public virtual void Devolver() {
            EstaDisponivel = true;
        }

    }
}
