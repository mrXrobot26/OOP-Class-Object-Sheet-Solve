using System.Linq;
using System.Transactions;

namespace OOPTask1
{
    internal class Program
    {
        static bool stopLoop = false;
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int chose;
            while (true)
            {
                Console.WriteLine($"1-Add User \n2-Update Data of User \n3-Delete User\n4-Print All User");
                string input = Console.ReadLine();
                User user = new User();


                if (int.TryParse(input, out chose))
                {
                    if (chose == 1)
                    {
                        user.AddUser(users);
                    }
                    else if (chose == 2)
                    {
                        user.UpdateUser(users);
                    }
                    else if (chose == 3)
                    {
                        user.DeleteUser(users);
                    }
                    else if (chose == 4)
                    {
                        user.PrintAllUser(users);
                    }
                    else
                    {
                        Console.WriteLine("You Enter Wrong Number!!");

                    }

                    TryAgain();
                    if (stopLoop)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("==========================================================");
                }
            }


        }
        static void TryAgain()
        {
            Console.WriteLine($"===================================================================");

            Console.WriteLine("Do you want to try anything else ? \n Y for yes || N for no");
            char tryAgain = char.Parse(Console.ReadLine());
            if (tryAgain == 'Y' || tryAgain == 'y')
            {
                Console.WriteLine($"===================================================================");
            }
            else if (tryAgain == 'N' || tryAgain == 'n')
            {
                stopLoop = true;
            }

        }
    }
}