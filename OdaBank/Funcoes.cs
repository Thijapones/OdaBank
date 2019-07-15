using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class Funcoes
    {
        public static void Depositos(int tipo)
        {
            Console.WriteLine("Por favor, selecione a quantidade de notas a depositar ou digite X para retornar ao menu anterior.");
            var qtdnotas = Console.ReadLine();

            if (int.TryParse(qtdnotas, out int result))
            {
                if (tipo == 1)
                {
                    int a = Convert.ToInt32(qtdnotas);
                    DepositaNotas10.QtdNotas(a);
                    CalcValorTotal.ValorTotal();
                    Console.WriteLine("Saldo Atual: R$ " + Caixa.saldototal + ",00.");
                }
                if (tipo == 2)
                {
                    int a = Convert.ToInt32(qtdnotas);
                    DepositaNotas20.QtdNotas(a);
                    CalcValorTotal.ValorTotal();
                    Console.WriteLine("Saldo Atual: R$ " + Caixa.saldototal + ",00.");
                }
                if (tipo == 3)
                {
                    int a = Convert.ToInt32(qtdnotas);
                    DepositaNotas50.QtdNotas(a);
                    CalcValorTotal.ValorTotal();
                    Console.WriteLine("Saldo Atual: R$ " + Caixa.saldototal + ",00.");
                }
            }
            else
            {
                Console.WriteLine("Retornando ao Menu Principal.");
            }
            return;
        }
        public static void Saque()
        {
            Console.WriteLine("Por favor, selecione o valor a ser sacado ou digite X para retornar ao menu anterior.");
            var saque = Console.ReadLine();

            if (int.TryParse(saque, out int result) && result > 0)
            {
                if (Caixa.saldototal - result > 0)
                {
                    if ((result % 10) == 0)
                    {
                        var saldoparcial = result;
                        var saque50 = saldoparcial / 50;
                        if (saque50>Caixa.qtdnotas50)
                        {
                            saque50 = Caixa.qtdnotas50;
                        }
                        if (saque50 > 0)
                        {
                            SaqueNotas50.QtdNotas(saque50);
                            saldoparcial = saldoparcial - (saque50 * 50);
                        }
                        var saque20 = saldoparcial / 20;
                        if (saque20 > Caixa.qtdnotas20)
                        {
                            saque20 = Caixa.qtdnotas20;
                        }
                        if (saque20 > 0)
                        {
                            SaqueNotas20.QtdNotas(saque20);
                            saldoparcial = saldoparcial - (saque20 * 20);
                        }
                        var saque10 = saldoparcial / 10;
                        if (saque10 > 0)
                        {
                            SaqueNotas10.QtdNotas(saque10);
                            saldoparcial = saldoparcial - (saque10 * 10);
                        }
                        Caixa.saldototal = Caixa.saldototal - (saque50 * 50) - (saque20 * 20) - (saque10 * 10);

                        return;
                    }
                    else
                    {
                        Console.WriteLine("Favor selecionar apenas múltiplos de R$ 10,00 para um saque.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Saldo Insuficiente.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Retornando ao Menu Principal.");
            }
            return;
        }
    }
}
