using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai1A
            List<int> list = new List<int>() { 1, 3, 4, 5, 8, 9 };
            var num = list.Where(x => x > 4).Select(x => x *x).ToList();
            foreach (int y in num)
            {
                Console.WriteLine("Bình phương các số lớn hơn 4 trong List là: " + y);
            }
            // Bai1B
            string str = "chao mung den voi binh nguyen vo tan";
            var letter = str.Where(char.IsLetter).GroupBy(x => x)
            .Select(group => new {Key = group.Key, count = group.Count() });
            foreach(var y in letter)
            {
                Console.WriteLine(y + " ");
            }
            // Bai1C
            var words = str.Split(' ');
            var result = from word in words
                         where word.Equals(word.ToUpper())
                         select word;
            foreach (var itemc in result)
            {
                Console.WriteLine(itemc + " ");
            }
            Console.ReadLine();


        }
    }
}
