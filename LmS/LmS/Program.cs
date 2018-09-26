using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmS
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction introduction = new Introduction();
            List<string> results = introduction.AddIntroduction();
            introduction.DisplayIntroduction(results);

            Console.ReadLine();
        }
    }
}
