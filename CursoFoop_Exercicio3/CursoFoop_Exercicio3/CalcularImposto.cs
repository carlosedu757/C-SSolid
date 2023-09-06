namespace CursoFoop_Exercicio3
{
    class CalcularImposto
    {
        public decimal Calcular(ICalculaImposto icalc)
        {
            return icalc.CalculaImpostoPais();
        }
    }
}
