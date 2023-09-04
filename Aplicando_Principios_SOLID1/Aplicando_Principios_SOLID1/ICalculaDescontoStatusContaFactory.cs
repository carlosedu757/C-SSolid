using Aplicando_Principios_SOLID1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta
            GetCalculaDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}
