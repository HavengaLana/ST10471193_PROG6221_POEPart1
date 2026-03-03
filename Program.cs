using System.Numerics;

namespace ST10471193_PROG6221_POEPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bot message (blue)

            string botGreeting = "[BOT]: Welcome to the cybersecurity Awareness Bot! Im here to help you stay safe online.";
            Console.ForegroundColor = ConsoleColor.Blue;

            //make bot seem like its typing
            PrintBotBubble(botGreeting);
            PrintBotBubble("[BOT]: What is your name?");
            Console.ResetColor();

            // user input (green)
            Console.ForegroundColor= ConsoleColor.Green;
            string name = Console.ReadLine();

            //Right allign
            int windowWidth = Console.WindowWidth - 1;
            

            //Move the cursur
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            PrintUserBubble(name);
        }

        static void TypeWriterEffect(string message, int speed = 50)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        static void PrintBotBubble(String message)
        {
            int bubbleWidth = message.Length + 4;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("┌" + new string('─', bubbleWidth - 2) + "┐");
            Console.Write("|  ");

            //typerwriter effect added to bot messages

            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("|");
            Console.WriteLine("└" + new string('─', bubbleWidth - 2) + "┘");
            Console.ResetColor();
        }

        static void PrintUserBubble(string message)
        {
            int windowWidth = Console.WindowWidth - 1;
            int boxWidth = message.Length + 6;
            int indent = windowWidth - boxWidth;
            if (indent < 0) indent = 0;
            string space = new string(' ', indent);

            Console.ForegroundColor = ConsoleColor.Green;
            string line = new string('─', message.Length + 2);

            Console.WriteLine(space + "┌" + line + "┐");
            Console.WriteLine(space + "|" + message + "  |");
            Console.WriteLine(space + "└" + line + "┘");

            
        }
    }
}
