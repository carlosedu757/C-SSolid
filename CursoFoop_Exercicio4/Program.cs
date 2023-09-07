namespace CursoFoop_Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto celularSamsung = new Celular(new PromocaoDiaMaes());
            celularSamsung.Nome = "Celular Samsung Galaxy M10";
            celularSamsung.Preco = 1000;
            var precoCelular = celularSamsung.PrecoVenda();
            Console.WriteLine($"{celularSamsung.Nome} (20% Off): {precoCelular}");
        }
    }
}