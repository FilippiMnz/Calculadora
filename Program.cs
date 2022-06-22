using System;

namespace Calculadora
{
    class Programinha
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Qual operação aritimetica lhe convém no momento?: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair da aplicação");

            Console.WriteLine("************************");
            Console.WriteLine("Selecione alguma das opções: ");
            short resul = short.Parse(Console.ReadLine());

            switch (resul)
            {
                case 1: Soma(); break;
                case 2: Subtração(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 0: System.Environment.Exit(0); break;

            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Insira o Primeiro Valor: ");
            float Numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Segundo Valor: ");
            float Numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da Soma é " + (Numb1 + Numb2));
        }

        static void Subtração()
        {
            Console.Clear();
            Console.WriteLine("Insira o Primeiro Valor: ");
            float Numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Segundo Valor: ");
            float Numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da Subtração é " + (Numb1 - Numb2));
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Insira o Primeiro Valor: ");
            float Numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira um Segundo Valor: ");
            float Numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da Divisão é " + (Numb1 / Numb2));
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Insira o Primeiro Valor: ");
            float Numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Segundo Valor: ");
            float Numb2 = float.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da multiplicação é " + (Numb1 * Numb2));
        }
    }
}