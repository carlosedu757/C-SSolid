using Aplicando_Principios_SOLID1.Enum;
using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDesconto
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;
        public GerenciadorDesconto(ICalculaDescontoFidelidade _descontoFidelidade, ICalculaDescontoStatusContaFactory _descontoStatusConta)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoStatusConta = _descontoStatusConta;
        }

        public /*virtual*/ decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = descontoStatusConta.GetCalculaDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(precoProduto);

            precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

            return precoAposDesconto;
        }
    }
}
