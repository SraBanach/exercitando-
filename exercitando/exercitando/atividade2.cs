using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    internal class atividade2
    {

        public static void atividade2()
        {
            Console.Clear();
            Console.WriteLine("Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade ou menor de idade");
            Console.WriteLine("Qual é a sua idade?");
            int opcaoescolhida = int.Parse(Console.ReadLine());

            if (opcaoescolhida < 18)
            {
                Console.WriteLine("Você é menor de idade");
            }

            else
            {
                Console.WriteLine("Você é maior de idade");
            }
            Thread.Sleep(3000);
            Console.Clear();
            cabecalho();
            paginainicial();

        }

    }
}
