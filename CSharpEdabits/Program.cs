using System;
using System.Collections.Generic;

namespace CSharpEdabits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something and we will make it leet");
            string output = Console.ReadLine();
            output = leetSpeak(output);
            Console.WriteLine(output);
            /* PROBLEM STATEMENT
            Create a function that takes a 
            string as an argument
            store string in a variable
            break string into a list of characters
            *need a dictionary of hacker characters too //We had to do some googling to find out that dictionaries are a thing
            compare EACH character with the hacker characters
            replace the character with the hacker character
            and returns a coded (h4ck3r 5p34k) version of the string.

            Examples
            HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
            HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
            HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
            Notes
            In order to work properly, the function should replace all 
            "A"s with 4,
            "a"s with @,
            "e"s with 3, 
            "i"s with 1, 
            "o"s with 0, 
            "s"s with 5,
            "T"s with 7
            */

            //1. Understand the problem
            //Break it down into smaller problems
            //Prioritize the problems
            //Confirm understanding (usually when a client is available)
            //2. Plan the solution
            //Write psuedo code!

            //leetSpeak(string arg){
                //string leetString = arg
                //dictionary leetCharacters = {
                    //{'A', '4'},
                    //{'a', '@'},
                    //{'e', '3'}, 
                    //{'i', '1'}, 
                    //{'o', '0'}, 
                    //{'s', '5'},
                    //{'T', '7'}
                   //}
                //foreach(character in englishString){
                    //search dict to see if dict contains char (Compare)
                    //if found{
                        //replace the character with the dict character
                    //}
                //}
                //return leetString
            //}

            //Test the psuedo code on paper

            //3. Execution of the solution
            //Google fu! Just take the psuedo code and put it into Google with the "C#" added on and start
            //4. Review the solution
            //Test solution
            //Refactor - Change the code without changing the behaviour
            //Test again


        }
        private static string leetSpeak(string englishString)
        {
            string leetString = englishString;
            Dictionary<char, char> leetDict = new Dictionary<char, char>();
            leetDict.Add('A', '4');
            leetDict.Add('a', '@');
            leetDict.Add('E', '3');
            leetDict.Add('o', '0');
            leetDict.Add('O', '0');
            leetDict.Add('T', '7');
            leetDict.Add('S', '5');
            leetDict.Add('s', '5');

            foreach(char i in leetString)
            {
                if (leetDict.ContainsKey(i))
                {
                    char newChar = leetDict.GetValueOrDefault(i);
                    leetString = leetString.Replace(i, newChar);
                }
            }
            return leetString;
        }
    }
}