using System;
using System.Text;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write an extension method to check if astring starts with a capital letter or not.

            Console.WriteLine("Write your word:");
            string word = Console.ReadLine();
            Console.WriteLine($"{word.UpperCase()}");


            //2.Write an extension method that appends an ‘s’to astring.

            Console.WriteLine("Write your word:");
            string word2 = Console.ReadLine();
            Console.WriteLine($"Your pluralized word is {word2.Pluralize()}");




            //3.Write an extension method that will capitalize a word.

            Console.WriteLine("Write your word:");
            string word3 = Console.ReadLine();
            Console.WriteLine($"Your new word is {word3.Capitalize()}");


            
            //4.Write a program that will capitalize a string , and pluralize the same string.
            

            Console.WriteLine("Write your word:");
            string word4 = Console.ReadLine();
            Console.WriteLine($"Your bew word is {word4.CapitalizeAndPluralize()}");



           
            //5.Write an extension method what will count the number of characters in a string.


            Console.WriteLine("Write your word:");
            string word5 = Console.ReadLine();
            Console.WriteLine($"The length of your characters: {word5.Count()}");



            
            //6.Write an extension method that will apply a VAT of 24% on an input.


            Console.WriteLine("Write your input:");
            string number = Console.ReadLine();
            decimal newinput = Convert.ToDecimal(number);
            Console.WriteLine($"Your VAT is {newinput.Vat()}");
            

        }
    }

    static class Extensions
    {
        //Capital letter


        public static bool UpperCase(this string str)
        {
            if (str != string.Empty)
            {
                if (str[0] == char.ToUpper(str[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Write an extension method that appends an ‘s’to astring.

        public static string Pluralize(this string str)
        {

            StringBuilder s = new StringBuilder();
            s.Append(str);
            s.Append('s');
            return s.ToString();



        }
       
        //Capitalize word
        
        public static string Capitalize(this string str)
        {
            if (str != string.Empty)
            {
                char a = str[0];
                a = char.ToUpper(a);
                StringBuilder s = new StringBuilder();
                s.Append(a);
                s.Append(str.Substring(1));
                return s.ToString();
            }
            else
            {
                return str;
            }
        }

        // Capitalize and pluralize
        
        public static string CapitalizeAndPluralize(this string str)
        {
            return str.Capitalize().Pluralize();
        }

        // Character count
        
        public static int Count(this string str)
        {
            return str.Length;
        }

        // VAT
        public static decimal Vat(this decimal str)
        {
            return 0.24M * str;
        }
        
    }
}


    

