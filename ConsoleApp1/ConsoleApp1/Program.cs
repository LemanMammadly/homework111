using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Username daxil edin :");
                string name = Console.ReadLine();
                Console.WriteLine("Passwordu daxil edin :");
                string passw = Console.ReadLine();
                User user = new User(name, passw);
                user.Username = name;



                int countUpper = 0;
                int countLower = 0;
                int countDigit = 0;
                foreach (char item in passw)
                {
                    if (char.IsUpper(item))
                    {
                        countUpper++;
                    }
                    else if (char.IsLower(item))
                    {
                        countLower++;
                    }
                    else if (char.IsDigit(item))
                    {
                        countDigit++;
                    }
                }
                if (countUpper >= 1 && countLower >= 1 && countDigit >= 1)
                {
                    user.PassWord = passw;
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlis parol..");
                }

            } while (true);

        }
    }
}
