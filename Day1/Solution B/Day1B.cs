using System.IO;
using System.Text.RegularExpressions;

namespace day1
{
    class day1
    {
        static void Main()
        {
            int sum = 0;
            string one;
            string two;
            string three;
            string four;
            string five;
            string six;
            string seven;
            string eight;
            string nine;
            string path = @".\textfile.txt";
            string lines = File.ReadAllText (path);
          
           
           one = Regex.Replace(lines, "one", "1");
           two = Regex.Replace(one, "two", "2");
           three = Regex.Replace(two, "three", "3");
           four = Regex.Replace(three, "four", "4");
           five = Regex.Replace(four, "five", "5");
           six = Regex.Replace(five, "six", "6");
           seven = Regex.Replace(six, "seven", "7");
           eight = Regex.Replace(seven, "eight", "8");
           nine = Regex.Replace(eight, "nine", "9");
           //Console.WriteLine(nine);
           string line = Regex.Replace(nine, "[a-z]", "");
           List<string> numbers = line.Split('\n').ToList();
           
           foreach (var i in numbers)
           {
            int last = i.Length-2;
           //Console.WriteLine(i);
           if (last >= 0)
           {
            int first = Convert.ToInt32(i.Substring(0,1));
            int second = Convert.ToInt32(i.Substring(last,1));
         
            sum += first * 10 + second;
            Console.WriteLine(sum);
           }
            else
            {
            break;
            }
             
           }
               
          



        }
    }
}