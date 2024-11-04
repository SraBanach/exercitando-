using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    public class Program
    {
        static void Main(string[] args)
        {
            cabecalho();
            paginainicial();

        }
        static void cabecalho()
        {
            Console.WriteLine("                           Autor(a) Kenya Banach");

            Console.WriteLine(@"███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");


        }

        public static void paginainicial()
        {
            Console.WriteLine("Escolha uma atividade:");
            Console.WriteLine("Atividade 1");
            Console.WriteLine("Atividade 2");
            Console.WriteLine("Atividade 3");
            Console.WriteLine("Atividade 4");
            Console.WriteLine("Atividade 5");
            Console.WriteLine("Atividade 6");
            Console.WriteLine("Pressione 00 para sair");

            int opcaoescolhida = int.Parse(Console.ReadLine());

            switch (opcaoescolhida)
            {
                case 1:
                    atividade1();
                    break;
                case 2:
                    atividade2();
                    break;
                case 3:
                    atividade2();
                    break;
                case 4:
                    atividade4();
                    break;
                case 5:
                    atividade5();
                    break;
                case 6:
                    atividade6();
                    break;
                case 7:
                    sair();
                    break;
            }

        }
        public static void atividade1()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que verifique se o numero fornecido pelo usuario é positivo, negtivo ou zero");
            Console.WriteLine("Digite um numero: ");
            int opcaoescolhida = int.Parse(Console.ReadLine());
            if (opcaoescolhida > 1)
            {
                Console.WriteLine("O numero é positivo");
            }
            else if (opcaoescolhida == 0)
            {
                Console.WriteLine("O numero é zero");
            }
            else
            {
                Console.WriteLine("O valor é negativo");
            }
            Thread.Sleep(3000);
            Console.Clear() ;
            cabecalho();
            paginainicial();
        }

        public static void atividade2() 
        { 
            Console.Clear ();
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
            Console.Clear () ;
            cabecalho();
            paginainicial ();

        }

        public static void atividade3()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que verifique se um numero é par ou impar");
            int opcaoescolhida = int.Parse(Console.ReadLine());

            if (opcaoescolhida %2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
            Thread.Sleep(3000);
            Console.Clear();
            cabecalho();
            paginainicial ();
        }

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
            Console.Clear ();
            cabecalho();
            paginainicial();

        }
        public static void atividade5()
        {
            Console.Clear();
            Console.WriteLine("Faça um programa que leia a nota de um aluno e informe se ele esta aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor do que 5)");
            int opcaoescolhida = int.Parse(Console.ReadLine());

            if (opcaoescolhida >= 7 )
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
        public static void sair() 
        {
        
            Console.Clear();
            Console.WriteLine(@"
░██████╗░█████╗░██╗██████╗░
██╔════╝██╔══██╗██║██╔══██╗
╚█████╗░███████║██║██████╔╝
░╚═══██╗██╔══██║██║██╔══██╗
██████╔╝██║░░██║██║██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚═╝");
        }

    }
}