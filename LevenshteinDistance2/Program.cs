using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevenshteinDistance2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "你好蒂蒂";
            //string str2 = "你好蒂芬"; 
            string str1 = "浙江省德清县";
            string str2 = "德清县";
            Console.WriteLine("字符串1 {0}", str1);
            Console.WriteLine("字符串2 {0}", str2);

            Console.WriteLine("相似度 {0} %", LevenshteinDistance.Instance.LevenshteinDistancePercent(str1, str2) * 100);
            Console.ReadLine();
        }
    }
}
