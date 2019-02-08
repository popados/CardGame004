using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfWords004
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            string[] lines = File.ReadAllLines(@"C:\Users\Nik\source\repos\BagOfWords002\federalist_docs.txt");
            string[] words = File.ReadAllLines(@"C:\Users\Nik\source\repos\BagOfWords002\BagOfWords002\bin\Debug\SavedFreqFedOne.txt");
            List<string> ArrayDocOne = new List<string>();
            List<string> uniqueWords = new List<string>();
            foreach (string line in lines)
            {
                counter++;
                string[] wordTemps = line.Split(' ');
                foreach (string array1Filestring in lines)
                {
                    string[] word1Temps = array1Filestring.Split(' ');

                    var result = word1Temps.Where(word => !string.IsNullOrEmpty(word) && wordTemps.Contains(word)).ToList();

                    if (result.Count > 0)
                    {
                        ArrayDocOne.AddRange(result);
                    }
                    TextWriter tw = new StreamWriter("SavedFreqFedOne.txt");

                    foreach (var s in ArrayDocOne)
                    {
                        
                        tw.WriteLine(s);
                    }
                    tw.Close();
                }
            }

                    //Read the first line of text
                    //Continue to read until you reach end of file
                    while (lines != null)
            {
                //write the lie to console window
                Console.WriteLine(lines);

            }

            Console.ReadLine();

        }
    }
}
