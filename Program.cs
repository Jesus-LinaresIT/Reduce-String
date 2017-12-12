using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace ProgramList
{
    class Program
    {

        static void Main(string[] args)
        {

            String Words_Str = "";
            Console.WriteLine("Write the text string: ");
            cadena = Console.ReadLine();
            var letter = Words_Str.ToCharArray();
            string letters = new string(letter);
            Console.WriteLine("Original String: {0}", Words_Str);
            Console.WriteLine("Iteration done: ");
            List<char> evaluation = new List<char>();
            bool flag = false;
            string dataR = "";

            for (int c = 0; c < letter.Length; c++)
            {

                Console.WriteLine("{1}", c, Words_Str[c]);

                if (c == 0)
                {
                    evaluation.Add(letter[c]);
                }
                else
                {

                    foreach (char dr in evaluation)
                    {
                        if (dr == letter[c])
                        {

                            flag = true;
                            continue;

                        }
                    }


                    if (flag == false)
                    {

                        evaluation.Add(letter[c]);
                    }
                    else {

                        flag = false;

                    }


                }
            
            }

            foreach (char item in evaluation)
            {
                
                dataR = dataR + item;                
                
            }


            Console.WriteLine("Final chain: {0}", dataR);
            

            Console.ReadKey();
        }
    }
}










