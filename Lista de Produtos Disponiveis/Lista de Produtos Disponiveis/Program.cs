using System;
using System.Collections.Generic;
using System.Linq;


namespace Lista_de_Produtos_Disponiveis
{
    class Program
    {
        /*
            Escrever um programa que recebe alguns produtos como argumento, validar se esses produtos estão na lista de 
            itens disponíveis do mercado. Caso estejam, avisar o usuário quais produtos tem e quais não tem e, por último, 
            exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado, para que o usuário possa pedir 
            na próxima vez. 
         */
        static void Main(string[] argumentos)
        {
            //criar a lista de produtos que nosso mercado tem
            List<string> produtosDisponiveis = new List<string>()
            {
                "pão", "leite", "manteiga", "requeijão", "refrigerante", "arroz", "alface", "Alface", "tomate", "frango", "doce"
            };

            //Validar se os argumentos foram preenchidos
            try
            {
                //listar quais produtos informados do argumento tem na lista do mercado
                var produtosSelecionados = produtosDisponiveis.Where(produto => argumentos.Contains(produto)).ToList();
                foreach(var produtoSelecionado in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nos temos: {produtoSelecionado}");
                }

                //Listar quais produtos informados no argumentos não tem no mercado
                var produtosNaoDisponiveis = argumentos.Where(argumentos => !produtosDisponiveis.Contains(argumentos)).ToList();
                foreach(var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nós não temos infelizmente =/: {produtoNaoDisponivel}");
                }

                //retornar a lista de produtos disponíveis do mercado ORDENADOS em ordem alfabética
                var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto).ToList();
                foreach(var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto disponivel: ${produtoOrdenado}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos invalidos");
            }

        }
    }
}
