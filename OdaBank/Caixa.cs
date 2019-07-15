using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class Caixa
    {
        public static int qtdnotas10 = 0;
        public static int qtdnotas20 = 0;
        public static int qtdnotas50 = 0;
        public static int saldototal = 0;
        public static void Main(string[] args)
        {
            var x = MenuPrincipal.MenuInicial();

            while (x != 5 && x!=0)
            {
               if (x < 4)
               {
                    Funcoes.Depositos(x);
                    x=MenuPrincipal.MenuInicial();
               }
               if (x==4)
                {
                    Funcoes.Saque();
                    x = MenuPrincipal.MenuInicial();
                }
            }
            MenuPrincipal.Sair(x);
        }
    }
}
