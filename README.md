# OdaBank
Caixa Eletrônico

[![Build status](https://ci.appveyor.com/api/projects/status/3be2fcvixcpu8u4l?svg=true)](https://ci.appveyor.com/project/Thijapones/odabank)

## How to Use

```CS
using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    /// <summary>
    /// Controle geral
    /// </summary>
    public class Caixa
    {
        public static int qtdnotas10 = 0;
        public static int qtdnotas20 = 0;
        public static int qtdnotas50 = 0;
        public static int saldototal = 0;
        public static void Main(string[] args)
        {
            //Chama Menu para Usuário.
            var x = MenuPrincipal.MenuInicial();

            //Enquanto a opção selecionada pelo cliente gerar um retorno, não encerra o programa.
            while (x != 5 && x!=0)
            {
               //Depósitos
               if (x < 4)
               {
                    Funcoes.Depositos(x);
                    x=MenuPrincipal.MenuInicial();
                    continue;
               }
               //Saques
               if (x==4)
                {
                    Funcoes.Saque();
                    x = MenuPrincipal.MenuInicial();
                }
            }
            //Quando a opção selecionada for a de saída, ou inválida, chama o método de saída.
            MenuPrincipal.Sair(x);
        }
    }
}
```
