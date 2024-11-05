using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    internal class atividade5
    {

        public static void atividade5()
        {
            Console.Clear();
            Console.WriteLine("Faça um programa que leia a nota de um aluno e informe se ele esta aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor do que 5)");
            int opcaoescolhida = int.Parse(Console.ReadLine());

            if (opcaoescolhida >= 7)
            {
                Console.WriteLine("Você esta aprovado!");
            }
            else if (opcaoescolhida < 5)
            {
                Console.WriteLine("Você está reprovado!");
            }
            else
            {
                Console.WriteLine("Você está em recuperação!");
            }
            Thread.Sleep(3000);
            Console.Clear();
            cabecalho();
            paginainicial();
        }

    }
}
