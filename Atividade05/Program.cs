using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            while (resposta != "S")
            {
                Console.Clear();
                Console.Write("1 - Cadastro aluno ");
                Console.Write("2 - Informar notas ");
                Console.Write("3 - Calcular médias ");
                Console.Write("4 - Exibir resultados ");
                Console.Write("S - Sair ");
                Console.Write(" Escolher a Opção: ");
                resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.Write("Digite o nome do aluno ");
                    string nome = Console.ReadLine();
                }
                else if (resposta == "2")
                {
                    Console.Write("Digite a primeira nota ");
                    double nota1 = Convert.ToDouble(Console.ReadLine());
                }



            }
        }
    }
}
