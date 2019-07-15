using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class DepositaNotas50 : IContador
    {
        public static int QtdNotas(int a)
        {
            var qtdnotas = Caixa.qtdnotas50 + a;
            Caixa.qtdnotas50 = qtdnotas;
            return qtdnotas;
        }
    }
}