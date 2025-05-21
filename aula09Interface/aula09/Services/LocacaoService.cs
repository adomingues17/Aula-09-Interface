using aula09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09.Services
{
    public class LocacaoService
    {
        //métod de locação
        public void LocarItem(Cliente cliente, ILocavel item)
        {
            if (!item.EstaDisponivel)
            {
                Console.WriteLine($"{item.Titulo} não está disponível");
                return;
            }
            item.Alugar();
            Console.WriteLine($"{item.Titulo} está locado para o cliente {cliente.Nome}");
        }
        public void DevolverItem(Cliente cliente, ILocavel item) {
            if (item.EstaDisponivel) {
                Console.WriteLine($"{item.Titulo} está disponível.");
                return;                    
            }
            item.Devolver();
            Console.WriteLine($"{item.Titulo} devolvido por {cliente.Nome}");
        }
    }
}
