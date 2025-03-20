using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    class Produto
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public double? Preco { get; set; }
        public DateTime DataVencimento { get; set; }
        public string? Observacao { get; set; }

        public static List<Produto> ListaProduto = new List<Produto>();


        public Produto(string? codigo, string? nome, string? categoria, double? preco, DateTime dataVencimento, string observacao)
        {
            Codigo = codigo;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            DataVencimento = dataVencimento;
            Observacao = observacao;
        }

        // usado quando gera um costrutor
        public Produto()
        {

        }

        public void Cadastrar()
        {
            ListaProduto.Add(this);
        }
    }
}
