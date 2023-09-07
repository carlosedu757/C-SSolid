using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_Exercicio4
{
    public class PromocaoDiaNamorados : IPromocao
    {
        public decimal Desconto()
        {
            return 0.1M;
        }
    }
}
