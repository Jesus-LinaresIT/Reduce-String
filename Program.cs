using System;
using System.Collections.Generic;

namespace ProgramList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Words_Str = "";
            Console.WriteLine("Write the text string: ");
            Words_Str = Console.ReadLine();
            var letter = Words_Str.ToCharArray();
            var letters = new string(letter);
            Console.WriteLine("Original String: {0}", Words_Str);
            Console.WriteLine("Iteration done: ");
            var evaluation = new List<char>();
            var flag = false;
            var dataR = "";

            for (var c = 0; c < letter.Length; c++)
            {
                Console.WriteLine("{1}", c, Words_Str[c]);

                if (c == 0)
                {
                    evaluation.Add(letter[c]);
                }
                else
                {
                    foreach (var dr in evaluation)
                        if (dr == letter[c])
                        {
                            flag = true;
                        }


                    if (flag == false)
                        evaluation.Add(letter[c]);
                    else
                        flag = false;
                }
            }

            foreach (var item in evaluation)
                dataR = dataR + item;


            Console.WriteLine("Final chain: {0}", dataR);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}