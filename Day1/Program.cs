using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
namespace day1
{
    class day1
    {
        static void Main()
        {
            
            
            string path = @".\textfile.txt";
            string lines = File.ReadAllText (path);
          
            
    
           string line = Regex.Replace(lines, "[a-z]", "");
           List<string> numbers = line.Split('\n').ToList();
           
           foreach (var i in numbers)
           {
            int first = Convert.ToInt32(i.Substring(0,1));
            int second = Convert.ToInt32(i.Substring(last,1));
           // int second = i.LastIndexOf('.');
           // int sum = first * 10 + second;
        
              Console.WriteLine(second);
           }

          



        }
    }
}