using Aplicando_Principios_SOLID1.Enum;
using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDesconto
    {
        public /*virtual*/ decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;


            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = precoProduto;
                    break;

                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = CalculaDescontoPorStatus(precoProduto, Constantes.DESCONTO_CLIENTE_COMUM, descontoPorFidelidade);
                    break;

                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = CalculaDescontoPorStatus(precoProduto, Constantes.DESCONTO_CLIENTE_ESPECIAL, descontoPorFidelidade);
                    break;

                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = CalculaDescontoPorStatus(precoProduto, Constantes.DESCONTO_CLIENTE_VIP, descontoPorFidelidade);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return precoAposDesconto;
        }

        public static decimal CalculaDescontoPorStatus(decimal precoProduto, decimal desconto, decimal descontoPorFidelidade)
        {
            decimal precoAposDesconto = precoProduto - (desconto * precoProduto);

            return precoAposDesconto - descontoPorFidelidade * (precoProduto - (desconto * precoProduto));
        }
    }
}
