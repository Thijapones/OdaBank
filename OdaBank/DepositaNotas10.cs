using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class DepositaNotas10 : IContador
    {
        public static int QtdNotas(int a)
        {
            var qtdnotas = Caixa.qtdnotas10 + a;
            Caixa.qtdnotas10 = qtdnotas;
            return qtdnotas;
        }
    }
}
