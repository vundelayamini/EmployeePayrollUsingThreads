using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EmployeepayrollUsingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeePayRollService Using Threads");
            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");
            #region ParallelTasks
            Parallel.Invoke(() =>
            {
                Console.WriteLine("begin first task....");
                GetLongestWord(words);
            },//close ist action
            () =>
            {
                Console.WriteLine("Begin Second Task...");
                GetMostCommonWords(words);
            },
            () =>
            {
                Console.WriteLine("Begin third task...");
                GetMostCommonWords(words);
            }//close third action
            ); //close parallel.invoke
            #endregion
            Console.ReadKey();
        }

        private static void GetMostCommonWords(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into q
                                 orderby q.Count() descending
                                 select q.Key;
            var commonWord = frequencyOrder.Take(10);
        }
        public static string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieveing from {uri}");
            //Downlaod a web page the easy way
            string blog = new WebClient().DownloadString(uri);
            return blog.Split(
                new char[] { ' ', '\u000A', '.', ',', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }
        private static string GetLongestWord(string[] words)
        {
            string longestWord = (from w in words
                                  orderby w.Length descending
                                  select w).First();
            Console.WriteLine($"Tas 1 -- The longest word is {longestWord}.");
            return longestWord;

        }

    }
}


