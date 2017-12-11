using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosine
{
    class Program
    {
        static void Main(string[] args)
        {
            //String str1 = "1嗡嗡翁";
            //String str2 = "2嗡嗡嗡";
            //DateTime beforDT = System.DateTime.Now;
            //// 返回相似度的算法
            //double Similarity = Cosine.getSimilarity(str1, str2);
            //DateTime afterDT = System.DateTime.Now;
            //TimeSpan ts = afterDT.Subtract(beforDT);
            //Console.WriteLine("用时{0}ms:" + ts.TotalMilliseconds);
            //Console.WriteLine(Similarity);

            //String str3 = "余弦定理算法：doc1 与 doc2 相似度为：0.9954971, 耗时：22mm";
            //String str4 = "余弦定理算法：doc1 和doc2 相似度为：0.99425095, 用时：33mm";
            //DateTime beforDT1 = System.DateTime.Now;
            //double Similarity1 = Cosine.getSimilarity(str3, str4);
            //DateTime afterDT1 = System.DateTime.Now;
            //TimeSpan ts1 = afterDT1.Subtract(beforDT1);
            //Console.WriteLine("用时{0}ms:" + ts1.TotalMilliseconds);
            //Console.WriteLine(Similarity1);

            //String temp1 = "群安小区11幢";
            //String temp2 = "群安小区委员会";
            //DateTime before1 = System.DateTime.Now;
            //double similarity1 = Cosine.getSimilarity(temp1, temp2);
            //DateTime after1 = System.DateTime.Now;
            //TimeSpan tstemp = after1.Subtract(before1);
            //Console.WriteLine("用时{0}ms:" + tstemp.TotalMilliseconds);
            //Console.WriteLine(similarity1);


            //阈值初步设置为0.7
            //String t1 = "殷甲伟";
            //String t2 = "殷甲伟"; 
            String t1 = "浙江省德清县";
            String t2 = "德清县";
            DateTime be1 = System.DateTime.Now;
            double simi1 = Cosine.getSimilarity(t1, t2);
            DateTime af1 = System.DateTime.Now;
            TimeSpan temp = af1.Subtract(be1);
            Console.WriteLine("用时{0}ms:" + temp.TotalMilliseconds);
            Console.WriteLine(simi1);


            Console.ReadKey();

        }
    }
}
