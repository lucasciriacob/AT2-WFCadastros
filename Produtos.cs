using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastro
{
    public class Produtos
    {
        public Produtos(int Codigo,string?Nome,string?Descrição,string?Ativo,DateTime? DataCadastro) 
        {
            Codigo = Codigo;
            Nome = Nome;
            Descrição = Descrição;
            Ativo = Ativo;
 
            DataCadastro = DataCadastro;
        }
        public Produtos() { }
        
        public static List<Produtos> ListaProdutos = new List<Produtos>();
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descrição { get; set; }
        public string? Ativo { get; set; }

        public DateTime? DataCadastro { get; set; }

    }
}
