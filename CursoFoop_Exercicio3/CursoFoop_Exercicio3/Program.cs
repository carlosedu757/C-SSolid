using System;

namespace CursoFoop_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaImposto calc = new BrasilImposto();
            calc.TotalRenda = 1000;
            calc.TotalDeducao = 100;

            CalcularImposto calcular = new CalcularImposto();
            var valorTotalImposto = calcular.Calcular(calc);

            Console.WriteLine($"Brasil: R${valorTotalImposto.ToString("F")}");

            Console.WriteLine("Hello World!");
        }
    }
}
