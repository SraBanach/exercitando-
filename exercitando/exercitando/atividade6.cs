using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    internal class atividade6
    {

        public static void atividade6()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que leia o peso e a altura de uma pessoa e calcule o seu IMC, informando se esta abaixo do peso, no peso normal, acima do peso ou obeso");

            Console.WriteLine("Qual a sua altura ?");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu peso?");
            double peso = double.Parse(Console.ReadLine());


            double imc = peso / (altura * altura);


            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }

            else if (imc > 18.5 && imc < 24.9)
            {
                Console.WriteLine("Peso normal");
            }

            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Você esta acima do peso");
            }
            else
            {
                Console.WriteLine("Você esta com obesidade");
            }

            Thread.Sleep(3000);
            Console.Clear();
            cabecalho();
            paginainicial();

        }

    }
}
