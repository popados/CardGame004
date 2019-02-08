using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfWords003
{
    class Program
    {
        private static int counter;

        public static string LongestWord(string sen)
        {
            sen.Split(' ');
            string[] words = sen.Split(' ');


            return words.OrderByDescending(s => s.Length).First(); ;

        }
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nik\Desktop\federalist_docs.txt");
            string str;
            List<string> ArrayDocOne = new List<string>();
            Console.WriteLine(lines);
            foreach (string line in lines) {
                counter++;
                string[] wordTemps = line.Split(' ');
                foreach (string array1Filestring in lines)
                {
                    string[] word1Temps = array1Filestring.Split(' ');

                    var result = word1Temps.Where(y => !string.IsNullOrEmpty(y) && wordTemps.Contains(y)).ToList();

                    if (result.Count > 0)
                    {
                        ArrayDocOne.AddRange(result);

                    }
                    //Console.WriteLine(ArrayDocOne);
                    TextWriter tw = new StreamWriter("SavedFreqFedOne.txt");

                    foreach (var s in ArrayDocOne)
                    {
                        tw.WriteLine(s);
                    }
                    tw.Close();


                    //Console.WriteLine("\t" + line);
                }
                //Console.WriteLine(result);
            }
            string[] wordsFile = File.ReadAllLines(@"C:\Users\Nik\source\repos\BagOfWords003\BagOfWords003\bin\Debug\SavedFreqFedOne.txt");
            foreach (string word in wordsFile) {
                Console.WriteLine(word);
            }
            //string str = lines;
            //Console.WriteLine(lines);

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nik\source\repos\BagOfWords002\fed_one.txt");
            //string[] words = File.ReadAllLines(@"C:\Users\Nik\source\repos\BagOfWords002\BagOfWords002\bin\Debug\SavedFreqFedOne.txt");
            //List<string> ArrayDocOne = new List<string>();
            //List<string> uniqueWords = new List<string>();

            //foreach (string line in lines) {
            //    line.Split(' ');
            //    ArrayDocOne.ToString();
            //    TextWriter tw = new StreamWriter(@"C:\Users\Nik\source\repos\BagOfWords002\fed_one.txt");

            //    foreach (var s in ArrayDocOne)
            //    {
            //        tw.WriteLine(s);
            //    }
            //    tw.Close();
            //Console.WriteLine(line);


        }
        public static class counting
        {
            public static int CountStringOccurrences(List<string> text, string pattern)
            {
                int count = 0;
                int i = 0;
                while ((i = text.IndexOf(pattern, i)) != -1)
                {
                    i += pattern.Length;
                    count++;
                }
                return count;
            }
        }
    }
    }
