using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Caesar_Cipher
{
    static class Cipher
    {
        private static string encrypted_User_Statement;
        static char[] alphabet = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        static char[] key = new char[] { 'g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','a','b','c','d','e','f' };
        static int x = 0;
        

        public static string Encrypt_Statement(string statement) 
        {
            char[] statement_array = new char[statement.Length];
            using(StringReader sr = new StringReader(statement))
            {
                sr.Read(statement_array, 0, statement.Length);
            }
            for (int i = 0; i < statement_array.Length; i++) 
            {
                if(statement_array[i] == ' ')
                {
                    encrypted_User_Statement += " ";
                    goto skip;
                }
                for(int y = 0; y < alphabet.Length; y++)
                {
                    if (statement_array[i] == alphabet[y])
                    {
                        encrypted_User_Statement += key[y];
                        goto skip;
                    }
                }
            skip:;
            }
            return encrypted_User_Statement;
        }
    }
}
