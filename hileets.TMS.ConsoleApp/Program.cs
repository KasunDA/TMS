using System;
using System.Security;
using hileets.TMS.Controllers;
using hileets.TMS.Models;
using hileets.TMS.Views;

namespace hileets.TMS.ConsoleApp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
			new ErrorHandling(new VErrorHandler());
            //Code Not Related To You!
            try {
            
                Customer.Signup("Sai", "aa", "123456", "me@saiem.pro","0313", Gender.Male);
                Init();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
            //
            //Init();
        }

        public static void Init(){
            Top:
            Console.WriteLine("Select Option");
            Console.WriteLine("");
            Console.WriteLine("1) Admin");
            Console.WriteLine("2) Customer");
            Console.WriteLine("0) Exit");
            Console.WriteLine("");

            var option = Console.ReadKey();
            Console.WriteLine();
            if (option.Key == ConsoleKey.D1)
                AdminMenu();
            else if (option.Key == ConsoleKey.D2)
                CustomerMenu();
            else if (option.Key == ConsoleKey.D0)
                Environment.Exit(0);
            else
            {
                ErrorHandling.LogE("Wrong Option Selected!");
                goto Top;
            }
        }
        public static void CustomerMenu(){
            Console.WriteLine("*** Welcome To Customer Menu ***");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Signup");

            var option = Console.ReadKey();
            Console.WriteLine();
            if (option.Key == ConsoleKey.D1)
                Login();
            else if (option.Key == ConsoleKey.D2)
                CustomerMenu();
            else if (option.Key == ConsoleKey.D0)
                Environment.Exit(0);
            else
            {
            }

        }
        public static void AdminMenu()
        {
			Console.WriteLine("Admin Menu");
        }

        private static SecureString GetConsoleSecurePassword()
        {
            var pwd = new SecureString();
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if(pwd.Length > 0)
                    pwd.RemoveAt(pwd.Length - 1);
                    Console.Write("\b \b");
                }
                else
                {
                    pwd.AppendChar(i.KeyChar);
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            return pwd;
        }

        public static void Login(){
            Console.WriteLine("Enter your username");
            var usr = Console.ReadLine();
            Console.WriteLine("Enter your password");
            var securePass = GetConsoleSecurePassword();
            string pass = new System.Net.NetworkCredential("", securePass).Password;
            //if (!controller.Login(usr, pass))
            //    Init();
            //DisplayMenu();
        }

        public static void Signup(){
            
        }

        public static void DisplayMenu(){
            //controller.DisplayMenu();

        }
    }
}
