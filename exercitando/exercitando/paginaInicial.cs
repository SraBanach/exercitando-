using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitando
{
    internal class paginaInicial
    {

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
            }

        }

    }
}
