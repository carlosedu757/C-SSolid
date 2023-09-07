using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_Exercicio4
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        protected IPromocao promocao;

        public Produto(IPromocao promocao)
        {
            this.promocao = promocao;
        }

        public decimal DescontoPromocao()
        {
            return promocao.Desconto();
        }

        public decimal PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }

    }
}
