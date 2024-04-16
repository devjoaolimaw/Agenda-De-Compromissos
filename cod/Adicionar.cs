using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Agenda
{
    public static class Funcao
    {
        public static List<string> agenda = new List<string>();
        
        public static void AdicionarCompromisso()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o compromisso a adicionar: ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string compromisso = Console.ReadLine();
            agenda.Add(compromisso);
            Console.WriteLine("Compromisso adicionado com sucesso!");
            Menu.Interface();
        }

        public static void VisualizarCompromissos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=== Compromissos ===");
            Console.WriteLine("");
            if (agenda.Count == 0)
            {
                Console.WriteLine("Nenhum compromisso agendado.");
            }
            else
            {
                for (int i = 0; i < agenda.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {agenda[i]}");
                }
            }
            Console.ReadKey();
            Menu.Interface();
        }
    }
}