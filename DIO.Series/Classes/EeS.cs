﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    /// <summary>
    /// Classe de manipulação de entradas e saídas
    /// </summary>
    class EeS
    {
        /// <summary>
        /// Solicita ao usuário e valida uma entrada numérica Double
        /// </summary>
        /// <param name="pMsg">Mensagem de pedido de entrada ao usuário</param>
        /// <param name="pLoopUntilValid">Solicitar entrada até receber entrada válida</param>
        /// <returns></returns>
        public static double PedeEvalidaDouble(string pMsg, bool pLoopUntilValid = true)
        {
            bool isInputOk = false;
            double entradaDoUsuario = 0;
            while (!isInputOk && pLoopUntilValid)
            {
                try
                {
                    Console.WriteLine(pMsg);
                    entradaDoUsuario = double.Parse(EeS.ReadConsoleLine());
                    isInputOk = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite apenas números!");
                    isInputOk = false;
                }
            }
            return entradaDoUsuario;
        }

        /// <summary>
        /// Solicita ao usuário e valida uma entrada numérica int
        /// </summary>
        /// <param name="pMsg">Mensagem de pedido de entrada ao usuário</param>
        /// <param name="pLoopUntilValid">Solicitar entrada até receber entrada válida</param>
        /// <returns></returns>
        public static int PedeEvalidaInteger(string pMsg, bool pLoopUntilValid = true)
        {
            bool isInputOk = false;
            int entradaDoUsuario = 0;
            while (!isInputOk && pLoopUntilValid)
            {
                try
                {
                    Console.WriteLine(pMsg);
                    entradaDoUsuario = int.Parse(EeS.ReadConsoleLine());
                    isInputOk = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite apenas números!");
                    isInputOk = false;
                }
            }
            return entradaDoUsuario;
        }

        /// <summary>
        /// Executes EeS.ReadConsoleLine() and exits if "quit" or "sair" is typed
        /// </summary>
        /// <returns>User's console input</returns>
        public static string ReadConsoleLine()
        {
            string input = null;
            input = Console.ReadLine();
            if (input.ToUpper().Equals("SAIR") || input.ToUpper().Equals("EXIT") || 
                input.ToUpper().Equals("FECHAR") || input.ToUpper().Equals("QUIT"))
            {
                Environment.Exit(0);
            }
            return input;
        }

    }
}
