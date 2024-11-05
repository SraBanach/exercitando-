using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    internal class atividade4
    {

        public static void atividade4()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que leia o mes do ano e informe quantos dias ele tem");
            string opcaoescolhida = Console.ReadLine();

            if (opcaoescolhida == "abril" || opcaoescolhida == "junho" || opcaoescolhida == "setembro" || opcaoescolhida == "novembro")
            {
                Console.WriteLine("O mês tem 30 dias");
            }
            else if (opcaoescolhida == "fevereiro")
            {
                Console.WriteLine("O mês tem 28 dias");
            }
            else
            {
                Console.WriteLine("O mês tem 31 dias");
            }
            Thread.Sleep(3000);
            Console.Clear();
            cabecalho();
            paginainicial();

        }

    }
}
