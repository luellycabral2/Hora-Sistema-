using System;

namespace Hora_Sistema_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime HoraAtual; 

            HoraAtual = DateTime.Now;
            Console.Write("Data e Hora atual: ");
            Console.WriteLine($"{HoraAtual}");
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();

        }
    }
}
