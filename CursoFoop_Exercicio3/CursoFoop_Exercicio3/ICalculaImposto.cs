using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public interface ICalculaImposto
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalculaImpostoPais();
    }
}
