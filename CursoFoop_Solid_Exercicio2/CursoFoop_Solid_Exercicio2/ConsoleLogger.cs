using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    class ConsoleLogger : ILogger
    {
        void ILogger.Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
