using System;
using System.Collections.Generic;
using System.Linq;

namespace desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "João Silva";
            int idade1 = 20;
            double peso1 = 70.50;
            decimal altura1 = 1.90m;
            bool EhDev1 = true;

            string nome2 = "Pedro Silva";
            int idade2 = 27;
            double peso2 = 79.50;
            decimal altura2 = 1.72m;
            bool EhDev2 = true;

            string nome3 = "Guilherme Souza";
            int idade3 = 59;
            double peso3 = 91.50;
            decimal altura3 = 1.90m;
            bool EhDev3 = false;

            string nome4 = "Durval Silva";
            int idade4 = 16;
            double peso4 = 59.40;
            decimal altura4 = 1.69m;
            bool EhDev4 = true;

            //T1 - Somar a idade de todos Ubuntus

            int resultado;

            Console.Write("Idade do primeiro - >" + idade1 + "\n");

            Console.Write("Idade do segundo - >" + idade2 + "\n");

            Console.Write("Idade do terceiro - >" + idade3 + "\n");

            Console.Write("Idade do quarto - >" + idade4 + "\n");

            resultado = idade1 + idade2 + idade3 + idade4;

            Console.Write("resultado = " + resultado + "\n");


            //T2 - Agrupar os nomes de todos Ubuntus
            Console.Write("Nomes:" + "\n" + nome1 + "\n" + nome2 + "\n" + nome3 + "\n" + nome4 + "\n");

            //T3 - Calcular Média dos IMC de todos Ubuntus

            double altura1Double = (double)altura1;

            double imc1 = peso1 / (altura1Double * altura1Double);

            Console.WriteLine("\nResultado do imc 1 = " + imc1);

            double altura2Double = (double)altura2;

            double imc2 = peso2 / (altura2Double * altura2Double);

            Console.WriteLine("\nResultado do imc 2 = " + imc2);

            double altura3Double = (double)altura3;

            double imc3 = peso3 / (altura3Double * altura3Double);

            Console.WriteLine("\nResultado do imc 3 = " + imc3);

            double altura4Double = (double)altura4;

            double imc4 = peso4 / (altura4Double * altura4Double);

            Console.WriteLine("\nResultado do imc 4 = " + imc4);

            //T4 - Contar quantos Ubuntus sao Devs

            resultado = 1 + 1 + 1;

            Console.Write("\nUbuntus Devs:" + "\n" + nome1 + "\n" + nome2 + "\n" + nome4 + "\n");

            Console.Write("resultado = " + resultado + "\n");
            //T5 - Exibir somente Ubuntu com nome Silva

            Console.Write("\nPessoas com nome Silva:" + "\n" + nome1 + "\n" + nome2 + "\n" + nome4 + "\n");
        }
    }
}
