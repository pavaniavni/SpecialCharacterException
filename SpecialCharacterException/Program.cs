using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomException
{
    public class SpecialCharacterException : Exception
    {
        public SpecialCharacterException(string message) : base(message)
        {

        }
    }

    public class SpecialCharacter
    {
        String s = "[^a-zA-Z0-9]+";
        public void ShowCharac()
        {
            Regex r = new Regex(s);
            if (s == null)
            {
                Console.WriteLine("String is Null");
                return;
            }
            MatchCollection m = r.Matches(s);
            if (m.Count != 0)
                throw (new SpecialCharacterException("Special Character found"));
            else
                Console.WriteLine("Special Character {0} :", s);
        }
        static void Main(string[] args)
        {
            String str = "@#$&%!~";
            SpecialCharacter sc = new SpecialCharacter();
            try
            {
                sc.ShowCharac();
            }
            catch (SpecialCharacterException e)
            {
                Console.WriteLine("Custom execption is {0}", e.Message);
            }
        }
    }
}

