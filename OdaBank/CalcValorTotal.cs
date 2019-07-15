using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class CalcValorTotal
    {
        public static void ValorTotal()
        {
            var valor10 = Caixa.qtdnotas10 * 10;
            var valor20 = Caixa.qtdnotas20 * 20;
            var valor50 = Caixa.qtdnotas50 * 50;
            var valortotal = valor10 + valor20 + valor50;
            Caixa.saldototal = valortotal;
        }
    }
}
