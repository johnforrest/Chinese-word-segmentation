using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            //String temp1 = "群安小区11幢";
            //String temp2 = "群安小区委员会";
            String temp1 = "浙江省德清县";
            String temp2 = "德清县";

            DateTime before1 = System.DateTime.Now;

            //不需要降纬词表
            SVMModle svmModel = new SVMModle();
            double similarity1 = svmModel.Similarity(temp1, temp2);

            DateTime after1 = System.DateTime.Now;

            TimeSpan tstemp = after1.Subtract(before1);

            Console.WriteLine("用时{0}ms:" + tstemp.TotalMilliseconds);
            Console.WriteLine(similarity1);

            Console.ReadKey();
        }
    }
}
