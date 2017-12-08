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
            Console.WriteLine("Escribe la cadena de texto: ");
            cadena = Console.ReadLine();
            var letras = cadena.ToCharArray();
            string letters = new string(letras);
            Console.WriteLine("Cadena original: {0}", cadena);
            Console.WriteLine("Iteracion realizada: ");
            List<char> evaluacion = new List<char>();
            bool bandera = false;
            string datoR = "";

            for (int c = 0; c < letras.Length; c++)
            {

                Console.WriteLine("{1}", c, cadena[c]);

                if (c == 0)
                {
                    evaluacion.Add(letras[c]);
                }
                else
                {

                    foreach (char dr in evaluacion)
                    {
                        if (dr == letras[c])
                        {

                            bandera = true;
                            continue;

                        }
                    }


                    if (bandera == false)
                    {

                        evaluacion.Add(letras[c]);
                    }
                    else {

                        bandera = false;

                    }


                }
            
            }

            foreach (char item in evaluacion)
            {
                
                datoR = datoR + item;                
                
            }


            Console.WriteLine("Cadena final: {0}", datoR);
            

            Console.ReadKey();
        }
    }
}










