using System;

namespace Calculator{ 
    class Program {
        static void Main (string[] args) 
        {
            Console.WriteLine("Digite um número para realizar a operação: \n 1 - Soma\n 2 - Subtracao\n 3 - Divisão\n 4 - Multiplicação");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha) {
                case 1:
                    Soma();
                break;
                case 2:
                    Subtracao();
                break;
                case 3:
                    Divisao();
                break;
                case 4:
                    Multiplicacao();
                break;
            default: 
                Console.WriteLine("Número inválido.");
                break;
            }

        }

        static void Soma() {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado} ");
            // Console.WriteLine($"O resultado da soma é: {v1 + v2} ");


        }
    
        static void Subtracao() {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();

        }

        static void Divisao() {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();

        }

        static void Multiplicacao() {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();

        }
    }

}