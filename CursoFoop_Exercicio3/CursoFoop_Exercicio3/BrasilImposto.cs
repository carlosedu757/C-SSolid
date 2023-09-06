using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public class BrasilImposto : ICalculaImposto
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalculaImpostoPais()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 0.2M;
        }
    }
}
