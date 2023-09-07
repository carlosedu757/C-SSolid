using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio_5
{
    public interface IPedidoPizzaFactory
    {
        IPedidoPizza GetPedidoPizza(SaborPizza saborPizza);
    }
}
