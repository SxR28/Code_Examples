using System;
using System.Reflection.Metadata;

namespace Coding
{
    class Program
    {
        static LibraryUser User = new LibraryUser();
        static void Main(string[] args)
        {
            User.libraryLicense = true;

            reading(User.firstName, User.secondName);
            Console.WriteLine($"Full Name is {User.firstName + " " + User.secondName}");
        }

        static void reading(string first, string second)
        {
            Console.Write("First Name is : ");
            first = Console.ReadLine();
            User.firstName = first;
            
            Console.Write("Second Name is : ");
            second = Console.ReadLine();
            User.secondName = second;
        }
    }
}
