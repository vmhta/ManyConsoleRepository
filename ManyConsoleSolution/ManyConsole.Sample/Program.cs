using System;
using System.Collections.Generic;

namespace ManyConsole.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = GetCommands();

            // then run them.
            ConsoleCommandDispatcher.DispatchCommand(commands, args, Console.Out);
            Console.ReadLine();
        }

        public static IEnumerable<ConsoleCommand> GetCommands()
        {
            return ConsoleCommandDispatcher.FindCommandsInSameAssemblyAs(typeof(Program));
        }
    }
}
