using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
namespace day1
{
    class day1
    {
        static void Main()
        {
            int sum = 0;
            int summa = 0;
            string path = @".\textfile.txt";
            string lines = File.ReadAllText (path);
          
            
    
           string line = Regex.Replace(lines, "[a-z]", "");
           List<string> numbers = line.Split('\n').ToList();
           
           foreach (var i in numbers)
           {
            int last = i.Length - 2;
           // Console.WriteLine(last);
           if (last >= 0)
           {
            int first = Convert.ToInt32(i.Substring(0,1));
            int second = Convert.ToInt32(i.Substring(last,1));
         
            sum += first * 10 + second;
            
           }
            else
            {
            break;
            }
             Console.WriteLine(sum);
           }
               
          



        }
    }
}