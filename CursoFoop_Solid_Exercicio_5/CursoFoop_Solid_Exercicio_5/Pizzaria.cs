namespace CursoFoop_Solid_Exercicio_5
{
    class Pizzaria
    {

        private readonly IPedidoPizzaFactory pedidoPizzaFactory;
        public Pizzaria(IPedidoPizzaFactory pedidoPizzaFactory)
        {
            this.pedidoPizzaFactory = pedidoPizzaFactory;
        }
        public void CriarPizza(SaborPizza saborPizza)
        {
            pedidoPizzaFactory.GetPedidoPizza(saborPizza);
        }
    }
}
