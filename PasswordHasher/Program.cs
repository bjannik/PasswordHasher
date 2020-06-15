using Microsoft.Extensions.Configuration;
using PasswordManager.Services.PasswordManager;
using System;

namespace ConsoleProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            EmailService.SendMail();

        }

    }
}
