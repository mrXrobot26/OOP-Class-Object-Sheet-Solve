using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask1
{
    internal class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }


        public void AddUser(List<User> users)
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
        public void UpdateUser(List<User> users)
        {
            Console.WriteLine($"============================Update Data of User================================");
            Console.Write("Enter User Phone Number you want to Edit: ");
            string phoneNumber = Console.ReadLine();
            User Foundeduser = users.FirstOrDefault(x => x.phoneNumber == phoneNumber);
            bool flag = false;
            if (Foundeduser != null)
            {
                Console.Write("1-Edit Name: \n2-Edit Email: \n3-Edit PhoneNumber: \n");
                int choseToEdit = int.Parse(Console.ReadLine());
                if (choseToEdit == 1)
                {
                    Console.Write("Enter Edited Name: ");
                    string newName = Console.ReadLine();
                    Foundeduser.name = newName;
                    flag =true;
                }
                else if (choseToEdit == 2)
                {
                    Console.Write("Enter Edited Email: ");
                    string newEmail = Console.ReadLine();
                    Foundeduser.email = newEmail;
                    flag = true;

                }
                else if (choseToEdit == 3)
                {
                    Console.Write("Enter Edited Phone Number: ");
                    string newPhoneNumber = Console.ReadLine();
                    Foundeduser.phoneNumber = newPhoneNumber;
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Wrong Number Try Again From First"); ;
                }
                if (flag == true)
                {
                    Console.WriteLine($"============================New User Information you Edited================================");
                    Console.WriteLine($"Name: {Foundeduser.name}");
                    Console.WriteLine($"Email: {Foundeduser.email}");
                    Console.WriteLine($"Phone Number: {Foundeduser.phoneNumber}");
                }

            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }


        public void DeleteUser(List<User> users)
        {
            Console.WriteLine($"============================Delete User================================");
            Console.Write("Enter User Phone Number you want to Delete: ");
            string phoneNumber = Console.ReadLine();
            User Foundeduser = users.FirstOrDefault(x => x.phoneNumber == phoneNumber);
            var name = Foundeduser.name;
            if (Foundeduser != null)
            {
                users.Remove(Foundeduser);
                Console.WriteLine($"- YOU DELETE USER : {name}.");

            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }

        public void PrintAllUser(List<User> users)
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


    }
}
