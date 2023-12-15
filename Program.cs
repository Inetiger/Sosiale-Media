using System;
using System.Collections.Generic;
using System.Threading;

namespace Sosiale_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                start();
            }
        }

        static User HovedBruker = new User("Ine", "Ivensen", 19);
        private static new List<User> friends = new List<User>();

        private static void start()
        {
            Console.SetCursorPosition(50, 15);
            Ask("Press enter to continue");
            Console.Clear();
            switch (AskInt("Vil du:\n1. Legge til venner\n2. Fjern venner\n3. Se venner\n4. Se en venn\n5. Avslutt program"))
            {
                case 1:
                    Console.Clear();
                    AddFriend();
                    break;
                case 2:
                    Console.Clear();
                    RemoveFriend();
                    break;
                case 3:
                    Console.Clear();
                    PrintFriends();
                    break;
                case 4:
                    Console.Clear();
                    PrintOneFriend();
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }

        private static void AddFriend()
        {
            friends.Add(new User(Ask("Hva heter vennen din?"), Ask("Hva er bruker navnet til vennen din?"), AskInt("Hvor gammel er vennen din?")));
        }

        private static void RemoveFriend()
        {
            int i = 0;
            foreach (var friend in friends)
            {
                i++;
                Console.WriteLine($"{i}. {friend._name}");
            }
            Console.WriteLine();
            friends.RemoveAt(AskInt("Hvilken venn vil du fjerne?") - 1);
        }

        private static void PrintFriends()
        {
            foreach (var friend in friends)
            {
                friend.PrintUserInfo();
            }
        }

        private static void PrintOneFriend()
        {
            int i = 0;
            foreach (var friend in friends)
            {
                i++;
                Console.WriteLine($"{i}. {friend._name}");
            }
            Console.WriteLine();
            friends[AskInt("Hvilken venn vil du se?") - 1].PrintUserInfo();
        }

        private static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        private static int AskInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }
    }
}
