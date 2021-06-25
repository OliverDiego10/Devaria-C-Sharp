using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Produtos_de_Mercado_Classes.Classes
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public string ExibirDadosProduto()
        {
            return $"Produto : {Nome} com valor de R$ {Preco}";

        }

    }
}
