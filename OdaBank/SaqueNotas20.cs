using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class SaqueNotas20 : IContador
    {
        public static int QtdNotas(int a)
        {
            var qtdnotas = Caixa.qtdnotas20 - a;
            Caixa.qtdnotas20 = qtdnotas;
            return qtdnotas;
        }
    }
}
