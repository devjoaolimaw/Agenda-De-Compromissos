using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Agenda
{
  class Menu
  {
    public static void Interface()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("=== Agenda de Compromissos ===");
            Console.WriteLine("");
            Console.WriteLine("1. Adicionar Compromisso");
            Console.WriteLine("2. Visualizar Compromissos");
            Console.WriteLine("0. Sair");
            Console.WriteLine("");
            Console.Write("Escolha uma opção: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Funcao.AdicionarCompromisso();
                    break;
                case "2":
                    Funcao.VisualizarCompromissos();
                    break;
                case "0":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
  }
}