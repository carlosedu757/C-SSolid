using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio_5
{
    public class PedidoPizzaFactory : IPedidoPizzaFactory
    {
        public IPedidoPizza GetPedidoPizza(SaborPizza saborPizza)
        {
            IPedidoPizza pizza;

            switch (saborPizza)
            {
                case SaborPizza.Mussarela:
                    pizza = new PizzaMussarela();
                    break;

                case SaborPizza.Calabresa:
                    pizza = new PizzaCalabresa();
                    break;

                default:
                    throw new NotImplementedException();
            }
            return pizza;
            
        }
    }
}
