using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class ListStrings
    {
        //member variables 
        List<String> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<String> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        //constructor

        //methods

        //problem 1 
        public void GetChChar()
        {
            IEnumerable<char> words =
            from ch in words
            where Char(ch)

        }

        //problem 2 






    }
}
