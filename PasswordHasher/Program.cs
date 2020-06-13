﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using ConsoleProgram.Services.PasswordManager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleProgram
{
    class Program
    {

        private static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            var passwordSalt = PasswordService.GenerateSalt();
            var passwordHash = PasswordService.ComputeHash("abc", passwordSalt);
            var passwordHash2 = PasswordService.ComputeHash("abcd", passwordSalt);

            if(PasswordService.Check(passwordHash, passwordHash2))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");


        }

    }
}
