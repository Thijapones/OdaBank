using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class Deposito
    {
        /// <summary>
        /// Funções de Depósito.
        /// Incrementa o saldo e a quantidade de notas de cada tipo dependendo da seleção
        /// pré-definida pelo usuário.
        /// Retorna para o menu principal caso a quantidade de notas digitada pelo usuário seja
        /// 0 ou inválida.
        /// </summary>
        /// <param name="tipo"></param>
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
    }
}
