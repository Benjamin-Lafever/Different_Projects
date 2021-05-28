using System;

namespace Caesar_Cipher
{
    class Caesar
    {
        private static string user_statement { get; set; }
        private static string encrypted_statement { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Message to become encrypted");
            user_statement = Console.ReadLine();
            encrypted_statement = Cipher.Encrypt_Statement(user_statement.ToLower());
            Console.WriteLine("Here is your encrypted statement: " + encrypted_statement.ToUpper());
            Console.WriteLine("Would you like to decrypt this statement?");

        }
    }
}
