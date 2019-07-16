using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class MenuPrincipal
    {
        /// <summary>
        /// Método de interface com o usuário.
        /// Mostra as opções e um breve extrato para os usuários.
        /// </summary>
        /// <returns></returns>
        public static int MenuInicial()
        {
            Console.WriteLine("Bem Vindo ao seu Caixa Odabank!\n");
            Console.WriteLine("Para depósitos acima de R$ 2.147.483.640,00, por favor dirija-se à agência OdaBank mais próxima.\n");
            Console.WriteLine("Selecione uma das opções abaixo:\n");
            Console.WriteLine("1 - Depositar Notas de R$ 10,00.");
            Console.WriteLine("2 - Depositar Notas de R$ 20,00.");
            Console.WriteLine("3 - Depositar Notas de R$ 50,00.");
            Console.WriteLine("4 - Realizar um Saque.");
            Console.WriteLine("5 - Sair do Sistema.\n");
            Console.WriteLine($"Saldo Atual Total R${Caixa.saldototal},00.\n");
            Console.WriteLine("Quantidade de Notas.\n");
            Console.WriteLine($"Notas de R$10,00 {Caixa.qtdnotas10}.");
            Console.WriteLine($"Notas de R$20,00 {Caixa.qtdnotas20}.");
            Console.WriteLine($"Notas de R$50,00 {Caixa.qtdnotas50}.");

            var oper = Console.ReadLine();

            if (int.TryParse(oper, out int result) && result > 0 && result < 6)
            {
                return Convert.ToInt32(oper);
            }
            else
            {
                return 0;
            }
        }
        //Método de tratativa de saída do programa. Normal End ou Abend.
        public static void Sair(int a)
        {
            if (a==5)
            {
                Console.WriteLine("Muito obrigado por utilizar o sistema OdaBank.");
            }
            else
            {
                Console.WriteLine("Erro crítico: Seleção Inválida.\n");
                Console.WriteLine("Em caso de dúvidas ou dificuldades, por favor, entre em contato com seu gerente OdaBank.");
            }
            return;
        }
    }
}
