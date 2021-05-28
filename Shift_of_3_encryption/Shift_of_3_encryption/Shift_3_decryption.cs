using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shift_of_3_encryption
{
    class Shift_3_decryption
    {
        private static string encrypted_User_Statement;
        static int x = 0;
        


        public static string Decrypt_Statement(string statement)
        {
            char[] statement_array = new char[statement.Length];
            using (StringReader sr = new StringReader(statement))
            {
                sr.Read(statement_array, 0, statement.Length);
            }
            for (int i = 0; i < statement_array.Length; i++)
            {
                if (statement_array[i] == ' ')
                {
                    encrypted_User_Statement += " ";
                    goto skip;
                }
                for (int y = 0; y < Key_repo.shift_3_Key.Length; y++)
                {
                    if (statement_array[i] == Key_repo.shift_3_Key[y])
                    {
                        encrypted_User_Statement += Key_repo.alphabet[y];
                        goto skip;
                    }
                }
            skip:;
            }
            return encrypted_User_Statement;
        }
    }
}

