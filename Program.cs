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

            String cadena = "";
            Console.WriteLine("Write the text string: ");
            cadena = Console.ReadLine();
            var letter = cadena.ToCharArray();
            string letters = new string(letras);
            Console.WriteLine("Original String: {0}", cadena);
            Console.WriteLine("Iteration done: ");
            List<char> evaluation = new List<char>();
            bool flag = false;
            string dataR = "";

            for (int c = 0; c < letter.Length; c++)
            {

                Console.WriteLine("{1}", c, cadena[c]);

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










