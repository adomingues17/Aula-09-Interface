using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09.Models
{
    internal class Revista : Item
    {
        public int Edicao { get; set; }

        public override void Alugar()
        {
            base.Alugar();
            Console.WriteLine($"Revista {Titulo} Ediçao {Edicao}");
        }

    }
}
