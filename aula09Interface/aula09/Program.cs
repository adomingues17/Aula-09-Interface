using aula09.Models;
using aula09.Services;
using System.Security.Cryptography;

namespace aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente { Nome = "Juan"};
            ILocavel livro = new Livro {Titulo = "C# do zero ao Deploy", Autor = "Arnaldo Domingues" };

            LocacaoService lS = new LocacaoService();
            lS.LocarItem(c1, livro);

            lS.DevolverItem(c1, livro);

            Console.WriteLine(new string('-', 30), "\n");

            ILocavel revista = new Revista {
                Titulo = "Impacta Global",
                Edicao = 100
            };

            LocacaoService lSR = new LocacaoService();
            lSR.LocarItem(c1, revista);







            



        }
    }
}
