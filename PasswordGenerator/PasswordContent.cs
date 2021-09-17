using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator
{
    class PasswordContent
    {
        private int length;

        private bool useUpper;
        private bool useLower;
        private bool useDigits;
        private bool useSpecial;

        private Char[] arrayPassword;

        public PasswordContent(
            int length, 
            bool useUpper, 
            bool useLower, 
            bool useDigits, 
            bool useSpecial)
        {
            this.length = length;
            this.useUpper = useUpper;
            this.useLower = useLower;
            this.useDigits = useDigits;
            this.useSpecial = useSpecial;

            
        }

        public String GetPassword() 
        {
            String password = "";
            
            Char[] code = new char[length];

            ArrayContent();

            //Console.WriteLine(arrayPassword);

            for (int i = 0; i < length; i++)
            {
                code[i] = GenerateCharacter();

            }


            password = new string(code);

            return password;
        }

        private Char GenerateCharacter() 
        {
            Random rnd = new Random();

            int i = rnd.Next(0, arrayPassword.Length); 


            return arrayPassword[i];
        }
       

        private void ArrayContent() 
        {
            String u = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String l = "abcdefghijklmnopqrstuvwxyz";
            String d = "1234567890";
            String c = "!@#$%&*()_+-=/.";
            String content = "";

            //atribui os valores das strings aos arrays
            if (useUpper) 
            {
                content = content + u;
            }

            if (useLower) 
            {
                content = content + l;
            }

            if (useDigits) 
            {
                content = content + d;
            }

            if (useSpecial) 
            {
                content = content + c;
            }

            this.arrayPassword = content.ToCharArray();


        }
    }
}
