using System;
namespace hileets.TMS.ConsoleApp
{
    public class VErrorHandler : IErrorHandler
    {
        public void LogError(string error)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(error);
            Console.ResetColor();
        }

        public void LogMsg(string message)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
