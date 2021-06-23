using System;

namespace Calculadora
{
    class Program
    {
        static float RealizarOperacao(float primeiroNumero, string operador)
        {
            switch (operador)
            {
                case "+": return primeiroNumero + segundoNumero;
                case "-": return primeiroNumero - segundoNumero;
                case "*": return primeiroNumero * segundoNumero;
                case "/": return primeiroNumero / segundoNumero;
                case "%": return primeiroNumero % segundoNumero;
                default: return 0f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um munero: ");
            var primeiroNumeroString = Console.ReadLine();
            float primeiroNumero;

            bool isPrimeiroNumeroValido = float.TryParse(primeiroNumeroString, out primeiroNumero);
            if (!isPrimeiroNumeroValido)
            {
                Console.WriteLine("Primeiro numero invalido: ");
                return;
            }
            Console.WriteLine("Informe o segundo numer: ");
            var segundoNumeroString = Console.ReadLine();
            float segundoNumero;

            bool isSegundoNumeroValido = float.TryParse(segundoNumeroString, out segundoNumero);
            if (!isSegundoNumeroValido) ;
            {
                Console.WriteLine("Primeiro numero invalido: ");
                return;
            }
            Console.WriteLine("Informe o operador matematico: ");
            var operador = Console.ReadLine();

            float resultado = RealizarOperacao(primeiroNumero, segundoNumero, operador);
            Console.WriteLine("O resultado da sua operação foi:" + resultado);
        }
    }
}
