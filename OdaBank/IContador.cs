using System;
using System.Collections.Generic;
using System.Text;

namespace OdaBank
{
    public class IContador
    {
        /// <summary>
        /// Interface que monta o contrato para novos tipos de contadores.
        /// Tanto os contadores de nota para saque quanto os de depósito
        /// devem seguir este padrão.
        /// </summary>
        public interface IContaNotas
        {
            int QtdNotas(int a);
        }
    }

}
