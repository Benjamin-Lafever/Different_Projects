using System;

namespace Shift_of_3_encryption
{
    class Program
    {
        private static string user_statement { get; set; }
        private static string encrypted_statement { get; set; }
        private static string decrypted_statement { get; set; }
        static string response;
        static void Main(string[] args)
        {
            retry:;
            Console.WriteLine("This program encrypts and decrypts data");
            Console.WriteLine("It uses a shift of 3 key");
            Console.WriteLine("Would you like to.");
            Console.WriteLine("1). Encrypt");
            Console.WriteLine("2). Decrypt");
            Console.WriteLine("Please enter a numberical value of 1 or 2...");
            response = Console.ReadLine();
            try
            {
                var attempt = Int32.Parse(response);
            }
            catch
            {
                Console.WriteLine("You input a non-compliant entry, please try again");
                goto retry;
            }
            var convert_response = Int32.Parse(response);
            if(convert_response != 2 && convert_response != 1)
            {
                Console.WriteLine("You input a non-compliant entry, please try again");
                goto retry;
            }
            if(convert_response == 1)
            {
                Console.WriteLine("Enter the statement you wish to encrypt");
                Console.WriteLine("(Please use letters and not numerals...)");
                user_statement = Console.ReadLine();
                encrypted_statement = Shift_3_encryption.Encrypt_Statement(user_statement.ToLower());
                Console.WriteLine("Your encrypted statement is: " + encrypted_statement.ToUpper());
            }
            if(convert_response == 2)
            {
                Console.WriteLine("Enter the statement you wish to decrypt");
                Console.WriteLine("(Please use letters and not numerals...)");
                user_statement = Console.ReadLine();
                encrypted_statement = Shift_3_decryption.Decrypt_Statement(user_statement.ToLower());
                Console.WriteLine("Your encrypted statement is: " + encrypted_statement.ToUpper());
            }


            
        }
    }
}
