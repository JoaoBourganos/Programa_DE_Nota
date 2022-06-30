using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_DE_Nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int media, trabalho, nota1, nota2;
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a nota do trabalho: ");
            trabalho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da primeira prova: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            media = (trabalho + nota1 + nota2) / 3;

            if (media >= 8.5)
            {
                Console.WriteLine("O conceito é A");
            }

            else if (media >= 7)
            {
                Console.WriteLine("O conceito é B");
            }

            else if (media >= 6)
            {
                Console.WriteLine("O conceito é C");
            }

            else if (media >= 0.1)
            {
                Console.WriteLine("O conceito é D");
            }

            else if (media == 0) 
            {
                Console.WriteLine("O conceito é E");
            }



            Console.ReadKey();

        }
    }
}
