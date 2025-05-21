using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09.Models
{
    public class Livro : Item
    {
        public string? Autor {  get; set; }

        public override void Alugar()
        {
            base.Alugar();
            Console.WriteLine($"Livro: {Titulo} foi alugado ");
        }

        public override void Devolver()
        {
            base.Devolver();
            Console.WriteLine($"Livro: {Titulo} foi devolvido");
        }


    }
}
