using System;
using Xunit;
using OdaBank;

namespace TestOdaBank
{
    /// <summary>
    /// Testes de cálculo de saldo.
    /// Caso haja algum erro no teste, a aplicação não deve ser disponibilizada de forma
    /// alguma para os usuários.
    /// </summary>
    public class TesteOdabank
    {
        [Theory]
        [InlineData(10, 20, 10)]
        [InlineData(3, 4, 2)]
        public void TestCalcValorTotal(int a, int b, int c)
        {
            Caixa.qtdnotas10 = a;
            Caixa.qtdnotas20 = b;
            Caixa.qtdnotas50 = c;

            var valortotal = a * 10 + b * 20 + c * 50;

            CalcValorTotal.ValorTotal();

            Assert.True(Caixa.saldototal == valortotal);
        }
    }
}