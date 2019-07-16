using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class Saque
    {
        /// <summary>
        /// Função de saque.
        /// Deve sempre retornar as maiores notas possíveis primeiro.
        /// Deve retornar um erro caso o valor desejado para saque seja maior que o saldo atual.
        /// Deve retornar um erro caso o valor desejado não seja múltiplo de 10.
        /// Deve retornar ao menu caso o valor de saque seja 0 ou inválido.
        /// Caso a quantidade de notas for insuficiente para retornar o valor exato, o maior
        /// aproximado será retornado para o usuário e uma mensagem de aviso será exibida.
        /// </summary>
        public static void Saques()
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
                        if (saque50 > Caixa.qtdnotas50)
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
                        if (saque10 > Caixa.qtdnotas10)
                        {
                            saque10 = Caixa.qtdnotas10;
                        }
                        if (saque10 > 0)
                        {
                            SaqueNotas10.QtdNotas(saque10);
                            saldoparcial = saldoparcial - (saque10 * 10);
                        }
                        Caixa.saldototal = Caixa.saldototal - (saque50 * 50) - (saque20 * 20) - (saque10 * 10);
                        if (saldoparcial != result)
                        {
                            Console.WriteLine("Notas insuficientes para resgatar o valor. O máximo valor aproximado será sacado.");
                        }
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
