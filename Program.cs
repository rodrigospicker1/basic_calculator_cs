﻿using System;

namespace Calculator{

    class Program{

        static void Main(string[] args){

            Menu();

        }

        static void Menu(){

            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("Digite 1 - Soma");
            Console.WriteLine("Digite 2 - Subtração");
            Console.WriteLine("Digite 3 - Divisão");
            Console.WriteLine("Digite 4 - Multiplicação");
            Console.WriteLine("Digite 5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");
            short answer = short.Parse(Console.ReadLine());

            switch(answer){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma(){

            Console.Clear();

            Console.WriteLine("SOMA");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){

            Console.Clear();

            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){

            Console.Clear();

            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1/v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){

            Console.Clear();

            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1*v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

    }

}