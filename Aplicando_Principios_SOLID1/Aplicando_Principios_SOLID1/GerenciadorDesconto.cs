using Aplicando_Principios_SOLID1.Enum;
using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDesconto
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        public GerenciadorDesconto(ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
        }

        public /*virtual*/ decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(precoProduto);
                    break;

                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = new ClienteComum().AplicarDescontoStatusConta(precoProduto);
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoProduto, tempoDeContaEmAnos);
                    break;

                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = new ClienteEspecial().AplicarDescontoStatusConta(precoProduto);
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoProduto, tempoDeContaEmAnos);
                    break;

                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = new ClienteVIP().AplicarDescontoStatusConta(precoProduto);
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoProduto, tempoDeContaEmAnos);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return precoAposDesconto;
        }
    }
}
