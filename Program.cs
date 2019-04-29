using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin
{
    class Program
    {
       

        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                while (true)
            { 
                Console.WriteLine("Enter a line to be translated");
                string str = Console.ReadLine();

                Console.WriteLine(ToPigLatin(str));
                Console.WriteLine("Translate another line?");
                Console.WriteLine("Continue? (y/n)");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {

                }
                else
                {
                    break;
                }

            }

        }
        public static int indexOfVowel;
        public static string ToPigLatin(String str)
        {

            string Lower = str.ToLower();
            string firstP = "";
            string secondP = "";

            if (IsVowel(Lower))
            {
                return Lower + "way";
            }
            else
            {
                foreach (char Letter in Lower)
                {
                    if (IsVowel(Letter))
                    {
                        indexOfVowel = Lower.IndexOf(Letter);
                        firstP = str.Substring(0,indexOfVowel);
                        secondP = str.Substring(indexOfVowel,str.Length -indexOfVowel);
                        break;
                    }
                    else if (IsVowel(Letter))
                    {
                        indexOfVowel = Lower.IndexOf(Letter);
                        firstP = str.Substring(0, indexOfVowel);
                        secondP = str.Substring(indexOfVowel, str.Length - indexOfVowel);
                        break;
                    }
                    else
                    {
                        continue;

                    }
                }
                return secondP + firstP + "ay";
            }



            

        }




        public static bool IsVowel(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char vowel in vowels)   
            {
                if(str[0] == vowel)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        public static bool IsVowel(char str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char vowel in vowels)
            {
                if (str == vowel)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        
    }
}
