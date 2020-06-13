using System;
using PasswordManager.Services.PasswordManager;

namespace ConsoleProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            Example();
        }

        private static void Example()
        {
            byte[] passwordSalt = PasswordService.GenerateSalt();
            byte[] passwordHash = PasswordService.ComputeHash("abcd", passwordSalt);
            byte[] passwordHash2 = PasswordService.ComputeHash("abcd", passwordSalt);

            Console.WriteLine(PasswordService.Check(passwordHash, passwordHash2));
        }
    }
}
