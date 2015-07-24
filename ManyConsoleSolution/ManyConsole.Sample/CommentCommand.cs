using ManyConsole;
using System;

namespace manyconsoleapp
{
    public class CommentCommand : ConsoleCommand
    {
        string _name;

        public CommentCommand()
        {
            IsCommand("comment");
            HasOption("c|comment=", "enter any comment", Name => _name = Name);
        }
        public override int Run(string[] remainingArguments)
        {
            if (string.IsNullOrWhiteSpace(_name))
            {
                Console.WriteLine("You made no comment");
            }
            else
            {
                Console.WriteLine("Your comment is: " + _name);
            }

            //Console.WriteLine("The remaining arguments were " + Newtonsoft.Json.JsonConvert.SerializeObject(remainingArguments));

            return 0;
        }
    }
}
