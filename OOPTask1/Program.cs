using System.Linq;
using System.Transactions;

namespace OOPTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int chose;
            while (true)
            {
                Console.WriteLine($"1-Add User \n2-Update Data of User \n3-Delete User\n4-Print All User");
                chose = int.Parse(Console.ReadLine());
                if (chose == 1)
                {
                    Console.WriteLine($"============================Add User================================");

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    string phoneNumber = Console.ReadLine();

                    User newUser = new User
                    {
                        name = name,
                        email = email,
                        phoneNumber = phoneNumber
                    };
                    users.Add(newUser);

                    Console.WriteLine($"============================User Information you Enterd================================");
                    Console.WriteLine($"Name: {newUser.name}");
                    Console.WriteLine($"Email: {newUser.email}");
                    Console.WriteLine($"Phone Number: {newUser.phoneNumber}");
                }
                else if (chose == 2)
                {
                    Console.WriteLine($"============================Update Data of User================================");
                    Console.Write("Enter User Phone Number you want to Edit: ");
                    string phoneNumber = Console.ReadLine();
                    User Foundeduser = users.FirstOrDefault(x => x.phoneNumber == phoneNumber);
                    if (Foundeduser != null)
                    {
                        Console.Write("1-Edit Name: \n2-Edit Email: \n3-Edit PhoneNumber: \n");
                        int choseToEdit = int.Parse( Console.ReadLine() );
                        if (choseToEdit==1)
                        {
                            Console.Write("Enter Edited Name: ");
                            string newName = Console.ReadLine();
                            Foundeduser.name = newName;

                        }
                        else if (choseToEdit == 2)
                        {
                            Console.Write("Enter Edited Email: ");
                            string newEmail = Console.ReadLine();
                            Foundeduser.email = newEmail;
                        }
                        else if (choseToEdit == 3)
                        {
                            Console.Write("Enter Edited Phone Number: ");
                            string newPhoneNumber = Console.ReadLine();
                            Foundeduser.phoneNumber = newPhoneNumber;
                        }
                        else
                        {
                            continue;
                        }
                        Console.WriteLine($"============================New User Information you Edited================================");
                        Console.WriteLine($"Name: {Foundeduser.name}");
                        Console.WriteLine($"Email: {Foundeduser.email}");
                        Console.WriteLine($"Phone Number: {Foundeduser.phoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine("No user Like this");
                    }
                }
                else if (chose == 3)
                {
                    Console.WriteLine($"============================Delete User================================");
                    Console.Write("Enter User Phone Number you want to Delete: ");
                    string phoneNumber = Console.ReadLine();
                    User Foundeduser = users.FirstOrDefault(x => x.phoneNumber == phoneNumber);
                    if (Foundeduser != null)
                    {
                        users.Remove(Foundeduser);
                    }
                    else
                    {
                        Console.WriteLine("No user Like this");
                    }
                }
                else if (chose == 4)
                {
                    int count = 1;
                    if (users.Count == 0)
                    {
                        Console.WriteLine($"===================================================================");

                        Console.WriteLine("No users to print");
                    }
                    else
                    {
                    Console.WriteLine($"============================Print All User================================");
                    }
                    
                    foreach (var user in users)
                    {
                        Console.WriteLine($"User {count}");
                        Console.WriteLine($"Name: {user.name}");
                        Console.WriteLine($"Email: {user.email}");
                        Console.WriteLine($"Phone Number: {user.phoneNumber}");
                        count++;
                        if (count <= users.Count)
                        {
                        Console.WriteLine("----------------");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("You Enter Wrong Number!!");

                }
                Console.WriteLine($"===================================================================");

                Console.WriteLine("Do you want to try anything else ? \n Y for yes || N for no");
                char tryAgain = char.Parse( Console.ReadLine() );
                if (tryAgain == 'Y' || tryAgain == 'y')
                {
                    Console.WriteLine($"===================================================================");
                    continue;
                }
                else if (tryAgain=='N' || tryAgain == 'n')
                {
                    break;
                }

            } 


        }
    }
}