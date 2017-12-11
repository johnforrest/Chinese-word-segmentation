using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevenshteinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 Distance;
            Double Similarity;
            string source = "浙江省德清县";
            string target = "德清县";
            Distance = LevenshteinDistance.LevenshteinDistance1(source, target, out Similarity, true);
            Console.WriteLine("编辑距离 = " + Distance.ToString());
            Console.WriteLine("相似度 = " + Similarity.ToString("0.####"));
            Console.WriteLine("------------------------------------");





            Console.ReadKey();
        }
       
    }
}
