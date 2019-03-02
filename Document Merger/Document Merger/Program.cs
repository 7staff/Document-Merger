using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document_Merger
{
    class Program
    {
        static void Prog()
        {
            Console.WriteLine("Document Merger");

            Console.WriteLine(" ");

            Console.WriteLine("Please Enter The First File Name: ");

            string input = Console.ReadLine();

            while (!File.Exists(input))
            {
                Console.WriteLine("This file does not exist. Try again");

                input = Console.ReadLine();
            }
                Console.WriteLine("Please Enter The Second File Name: ");

                string input2 = Console.ReadLine();

                while (!File.Exists(input2))
            {
                Console.WriteLine("This file does not exist. Try again");
                input2 = Console.ReadLine();
            }
                string inputText = File.ReadAllText(input);

                string input2Text = File.ReadAllText(input2);

                char[] Text = { '.', 't', 'x', 't' };

                input = input.TrimEnd(Text);

                input2 = input2.TrimEnd(Text);

                string newText = input + input2 + ".txt";

                string newTextFile = inputText + input2Text;

                File.AppendAllText(newText, newTextFile);

                StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(newText);
                writer.WriteLine(newTextFile);
                Console.WriteLine(newText + " was saved successfully. This document contains " + newTextFile.Length + " characters.");

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }

            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            Console.ReadKey();


        }
        static void Main(string[] args)
        {
            do
            {
                Prog();

                Console.WriteLine("Would you like to merge two more files? y or n)");   
                
                char c = Console.ReadLine()[0];         
                if (c == 'n')                          
                    break;                             
            } while (true);                            
        }
    }

}
