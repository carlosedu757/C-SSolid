using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_Exercicio4
{
    public class Celular : Produto
    {
        public Celular(IPromocao promocaoDiaMaes) : base(promocaoDiaMaes) { }
    }
}
