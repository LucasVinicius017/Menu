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
            string nome = "";
            double nota1 = 0, nota2 = 0, media = 0;


            string resposta = "";
            while (resposta.ToUpper() != "S")
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastro aluno ");
                Console.WriteLine("2 - Informar notas ");
                Console.WriteLine("3 - Calcular médias ");
                Console.WriteLine("4 - Exibir resultados ");
                Console.WriteLine("S - Sair ");
                Console.Write(" Escolher a Opção: ");
                resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.Clear();
                    Console.Write("Digite o nome do aluno ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Aluno cadastrado com sucesso");
                }
                else if (resposta == "2")
                {
                    Console.Clear();
                    Console.Write("Digite a primeira nota ");
                    nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a segunda nota ");
                    nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Notas cadastradas com sucesso!");
                }
                else if (resposta == "3")
                {
                    media = (nota1 + nota2) / 2;
                    Console.WriteLine("Media calculada!! ");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (resposta == "4")
                {
                    Console.WriteLine("Aluno: " + nome);
                    Console.WriteLine("Média: " + media);

                    if (media >= 5)
                    {
                        Console.WriteLine("Aluno aprovado");
                    }
                    else
                    {
                        Console.WriteLine("Aluno reprovado");
                    }
                    Console.ReadKey();
                }

            }
        }
    }
}
