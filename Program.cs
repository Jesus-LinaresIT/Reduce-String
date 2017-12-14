using System;
using System.Collections.Generic;

namespace ProgramList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======

            String Words_Str = "";
            Console.WriteLine("Write the text string: ");
            Words_Str = Console.ReadLine();
            var letter = Words_Str.ToCharArray();
            string letters = new string(letter);
            Console.WriteLine("Original String: {0}", Words_Str);
            Console.WriteLine("Iteration done: ");
            List<char> evaluation = new List<char>();
            bool flag = false;
            string dataR = "";

            for (int c = 0; c < letter.Length; c++)
            {

>>>>>>> 7a71b8660582560647e5b901c4fa2994b6144c35
                Console.WriteLine("{1}", c, Words_Str[c]);

                if (c == 0)
                {
                    evaluation.Add(letter[c]);
                }
                else
                {
<<<<<<< HEAD
                    foreach (var dr in evaluation)
                        if (dr == letter[c])
                        {
                            flag = true;
                        }
=======

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
>>>>>>> 7a71b8660582560647e5b901c4fa2994b6144c35


                    if (flag == false)
                        evaluation.Add(letter[c]);
                    else
                        flag = false;
                }
            }

<<<<<<< HEAD
            foreach (var item in evaluation)
                dataR = dataR + item;


            Console.WriteLine("Final chain: {0}", dataR);
=======
            foreach (char item in evaluation)
            {
                
                dataR = dataR + item;                
                
            }


            Console.WriteLine("Final chain: {0}", dataR);
            
>>>>>>> 7a71b8660582560647e5b901c4fa2994b6144c35

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}