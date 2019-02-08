using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfWords002
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] words = reader.ReadToEnd().Split(' ');

            int counter = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nik\source\repos\BagOfWords002\federalist_docs.txt");
            string[] words = File.ReadAllLines(@"C:\Users\Nik\source\repos\BagOfWords002\BagOfWords002\bin\Debug\SavedFreqFedOne.txt");
            List<string> ArrayDocOne = new List<string>();
            List<string> uniqueWords = new List<string>();

            //////add the words to a list
            foreach (string line in lines)
            {
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
                    //Console.WriteLine("\t" + line);
                }
            }
            TextWriter writeUnique = new StreamWriter("SavedFreqFedOneUniqueCount.txt");
            FrequencyDist<string> cs = new FrequencyDist<string>(ArrayDocOne);
            foreach (var v in cs.ItemFreq.Values) {
                writeUnique.WriteLine(v.value + " : " + v.count);
                string[] str;
                writeUnique.ToString();

            }
            writeUnique.Close();

            IEnumerable<string> nodupes = words.Distinct();
            TextWriter textwrite = new StreamWriter("SavedFreqFedOneUnique.txt");
            foreach (var word in nodupes) {
                textwrite.WriteLine(word);

                //textwrite.WriteLine(words.Distinct());
            }
            textwrite.Close();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //foreach(var

            //// Read the file and display it line by line.  
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Nik\source\repos\BagOfWords002\federalist_docs.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    System.Console.WriteLine(line);

            //}

            //file.Close();
            //Console.WriteLine("file array1.txt contians words: {0}", string.Join("\t", ArrayDocOne));
            System.Console.WriteLine("There were {0} lines.", counter);
            Console.WriteLine("the occurs: " + counting.CountStringOccurrences(ArrayDocOne, "the" ));
            ////// Suspend the screen.
            TextWriter tw = new StreamWriter("SavedFreqFedOne.txt");

            foreach (var s in ArrayDocOne)
            {
                tw.WriteLine(s);
            }
            tw.Close();

            Console.WriteLine("enter to continue.. this is to open a document in the same folder");
            Console.ReadKey();
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
    /// Manages Frequency Distributions for items of type T
    /// </summary>
 
    /// <typeparam name="T">Type for item</typeparam>
    public class FrequencyDist<T>
        {
        ///
        /// Construct Frequency Distribution for the given list of items
        /// </summary>
 
        /// <param name="li">List of items to calculate for</param>
        public FrequencyDist(List<T> li)
            {
                CalcFreqDist(li);
            }
 
        ///
        /// Construct Frequency Distribution for the given list of items, across all keys in itemValues
        /// </summary>
 
        /// <param name="li">List of items to calculate for</param>
        /// <param name="itemValues">Entire list of itemValues to include in the frequency distribution</param>
        public FrequencyDist(List<T> li, List<T> itemValues)
            {
                CalcFreqDist(li);
                // add items to frequency distribution that are in itemValues but missing from the frequency distribution
                foreach (var v in itemValues)
                {
                    if (!ItemFreq.Keys.Contains(v))
                    {
                        ItemFreq.Add(v, new Item { value = v, count = 0 });
                    }
                }
                // check that all values in li are in the itemValues list
                foreach (var v in li)
                {
                    if (!itemValues.Contains(v))
                        throw new Exception(string.Format("FrequencyDist: Value in list for frequency distribution not in supplied list of values: '{0}'.", v));
                }
            }
 
        ///
        /// Calculate the frequency distribution for the values in list
        /// </summary>
 
        /// <param name="li">List of items to calculate for</param>
        void CalcFreqDist(List<T> li)
            {
                itemFreq = new SortedList<T, Item>((from item in li
                                                    group item by item into theGroup
                                                    select new Item { value = theGroup.FirstOrDefault(), count = theGroup.Count() }).ToDictionary(q => q.value, q => q));
            }
            SortedList<T, Item> itemFreq = new SortedList<T, Item>();
 
        ///
        /// Getter for the Item Frequency list
        /// </summary>
 
        public SortedList<T, Item> ItemFreq { get { return itemFreq; } }

            public int Freq(T value)
            {
                if (itemFreq.Keys.Contains(value))
                {
                    return itemFreq[value].count;
                }
                else
                {
                    return 0;
                }
            }
 
        ///
        /// Returns the list of distinct values between two lists
        /// </summary>
 
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static List<T> GetDistinctValues(List<T> l1, List<T> l2)
            {
                return l1.Concat(l2).ToList().Distinct().ToList();
            }
 
        ///
        /// Manages a count of items (int, string etc) for frequency counts
        /// </summary>
 
        /// <typeparam name="T">The type for item</typeparam>
        public class Item
            {
            ///

            /// The value of the item, e.g. int or string
            /// </summary>
 
            public T value { get; set; }
            ///
            /// The count of the item
            /// </summary>
 
            public int count { get; set; }
            }
        }
    }
}
