using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqEG
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> allMarks = new List<int>();
            allMarks.Add(10);
            allMarks.Add(20); allMarks.Add(70); allMarks.Add(45); allMarks.Add(90);
            
            //query syntax
            var reqMarks = (from i in allMarks where i > 45 orderby i descending select i).ToList();   

            foreach(int item in reqMarks)
            {
                Console.WriteLine(item);
            }
            //hello
            //method syntax
            /*var reqMarks1 = allMarks.Where(i=>i>45).OrderByDescending(i=>i).Select(i => i).ToList();
            foreach (int item in reqMarks1)
            {
                Console.WriteLine(item);
            }*/

            List<string> fruits = new List<string>() {"apple","mango","strawberry","avocado","apricot"};

            //query syntax
            var fruitsquery = (from i in fruits where i.StartsWith('a') select i).ToList();
            
            foreach (string i in fruitsquery)
            {
                Console.WriteLine(i);
            }

            //method syntax
            var fruitsmethod = fruits.Where(x => x.StartsWith('a')).Select(x=>x).ToList();
            foreach (string i in fruitsmethod)
            {
                Console.WriteLine(i);
            }

        }
    }
}