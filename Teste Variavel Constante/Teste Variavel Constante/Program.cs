using System;

namespace Teste_Variavel_Constante
{
    class Program
    {
        private static object argumentos;

        static void Main(string[] args)
        {
            const string constante = "uma constante que não muda"; 

            if(argumentos.length == 0)
            {
                Console.WriteLine("Favor informar um número inteiro");
                return;
            }
            int inteiro;
            bool teste = int.TryParse(argumentos[0], out inteiro);

            if(teste == false
                {
                Console.WriteLine("o argumento informado não é um numero inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("o número informado foi: " + inteiro);
        }
    }
}
