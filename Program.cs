using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static string ToL33tSpeak(string password)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            password = password.ToLower();

            char[] passwordLetters = password.ToCharArray();

            for (int i = 0; i < passwordLetters.Length; i++)
            {
                if (passwordLetters[i] == naturalLetters[0])
                {
                    passwordLetters[i] = leetLetters[0];
                }
                else if (passwordLetters[i] == naturalLetters[1])
                {
                    passwordLetters[i] = leetLetters[1];
                }
                else if (passwordLetters[i] == naturalLetters[2])
                {
                    passwordLetters[i] = leetLetters[2];
                }
                else if (passwordLetters[i] == naturalLetters[3])
                {
                    passwordLetters[i] = leetLetters[3];
                }
                else if (passwordLetters[i] == naturalLetters[4])
                {
                    passwordLetters[i] = leetLetters[4];
                }
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
                if (passwordLetters[i] == leetLetters[0])
                {
                    passwordLetters[i] = naturalLetters[0];
                }
                else if (passwordLetters[i] == leetLetters[1])
                {
                    passwordLetters[i] = naturalLetters[1];
                }
                else if (passwordLetters[i] == leetLetters[2])
                {
                    passwordLetters[i] = naturalLetters[2];
                }
                else if (passwordLetters[i] == leetLetters[3])
                {
                    passwordLetters[i] = naturalLetters[3];
                }
                else if (passwordLetters[i] == leetLetters[4])
                {
                    passwordLetters[i] = naturalLetters[4];
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
