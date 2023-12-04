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
            
        
           
            Console.WriteLine(line);






        }
    }
}