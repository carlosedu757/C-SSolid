using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    public class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"c:\dados\log\LogOcorrencias.txt", mensagem);
        }

        
    }
}
