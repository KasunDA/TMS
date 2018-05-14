using System;
using System.Security;
using hileets.TMS.Controllers;
using hileets.TMS.DbContext;
using hileets.TMS.Models;
using hileets.TMS.Views;

namespace hileets.TMS.ConsoleApp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
			new ErrorHandling(new VErrorHandler());
            Init();
        }

        public static void Init(){
			var c = Customer.Signup("Saiem Saeed", "saiemsaeed", "1234567", "me@saiem.pro", "03135536246", Gender.Male);
			var d = Customer.Signup("Talha Saeed", "talhakhan", "123456", "tk@saiem.pro", "03135536246", Gender.Male);
            c.UserName = "Khan123";
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
			CustomerMenuTop:
            Console.WriteLine("*** Welcome To Customer Menu ***");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Signup");

            var option = Console.ReadKey();
            Console.WriteLine();
			if (option.Key == ConsoleKey.D1)
				Login();
			else if (option.Key == ConsoleKey.D2)
				Signup();
            else if (option.Key == ConsoleKey.D0)
                Environment.Exit(0);
            else
            {
				ErrorHandling.LogE("Wrong Option Selected!");
				goto CustomerMenuTop;
            }

        }
        public static void AdminMenu()
        {
			var index = 0;
			Console.WriteLine("Select an option");
            foreach(string menu in Admin.Menu){
                index++;
				Console.WriteLine("\t {0}) {1}",index,menu);
			}
            Console.ReadKey();
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
            var user = Console.ReadLine();
            Console.WriteLine("Enter your password");
            var securePass = GetConsoleSecurePassword();
            string pass = new System.Net.NetworkCredential("", securePass).Password;
			try{
				var cust = Customer.Login(user, pass);
				DisplayMenu();                      
			}catch(Exception e){
				Console.WriteLine(e.Message);
				CustomerMenu();           
            }
        }

        public static void Signup(){
			Console.WriteLine("\nEnter your fullname");
            var name = Console.ReadLine();

			Console.WriteLine("\nEnter your username");
            var username = Console.ReadLine();

			Console.WriteLine("\nEnter your email");
            var email = Console.ReadLine();

			Console.WriteLine("\nEnter your password");
            var securePass = GetConsoleSecurePassword();
            
			Console.WriteLine("\nEnter your phone number");
            var phone = Console.ReadLine();
            
			Console.WriteLine("\nEnter your gender");
			Console.WriteLine("\t1) Male");
			Console.WriteLine("\t2) Female");
			int gender = Convert.ToInt32(Console.ReadKey().Key);

            string pass = new System.Net.NetworkCredential("", securePass).Password;
            try
            {
				var cust = Customer.Signup(name, username,pass,email, phone, (Gender)gender);
				CustomerMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                CustomerMenu();
            }
        }

        public static void DisplayMenu(){
            Console.Clear();
            Console.WriteLine("Please select an option from the menu");
            var count = 0;
            foreach (string menu in Customer.Menu)
            {
                count++;
                Console.WriteLine("\t{0}) {1}", count, menu);
            }
            Console.ReadKey();
        }
    }
}
