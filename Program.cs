using System;

namespace sda_csharp_exercises
{
    class Program
    {

        private static char CharToLeet (char input)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            char output= input;

            for (int j = 0; j < naturalLetters.Length; j++)
            {
                if (input == naturalLetters[j])
                {
                    output = leetLetters[j];
                }
            }

            return output;
        }
        static string ToL33tSpeak(string password)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            password = password.ToLower();

            char[] passwordLetters = password.ToCharArray();

            for (int i = 0; i < passwordLetters.Length; i++)
            {

                passwordLetters[i] = CharToLeet(passwordLetters[i]);

            }
            
            string l33tPassword = new string(passwordLetters);

            return l33tPassword;
        }

        static string DecodeL33tSpeak(string password)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            password = password.ToLower();

            char[] passwordLetters = password.ToCharArray();

            for (int i = 0; i < passwordLetters.Length; i++)
            {
                for (int j = 0; j < leetLetters.Length; j++)
                {
                    if (passwordLetters[i] == leetLetters[j])
                    {
                        passwordLetters[i] = naturalLetters[j];
                    }
                }
            }

            string decodedPassword = new string(passwordLetters);

            return decodedPassword;
        }
        static void Main(string[] args)
        {

            Console.Write("Podaj hasło: ");
            string password = Console.ReadLine();

            Console.WriteLine("Twoje hasło w l33t speak to: " + ToL33tSpeak(password));

            Console.Write("Podaj hasło w l33t speak: ");
            string l33tPassword = Console.ReadLine();

            Console.Write("Twoje zdekodowane hasło to: " + DecodeL33tSpeak(l33tPassword));
        }
    }
}
