using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace foo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime beforDT = System.DateTime.Now;
            if (args.Count() < 1)
                return;
            string path = args[0];
            string[] sm = File.ReadAllLines(path);
            int[] p = new int[sm.Length];
            int[] array = new int[9000000];
            string qwe;
            for (int i = 0; ; i++)
            {
                qwe = Console.ReadLine();
                if (qwe.Length < 1) break;
                p[i] = Convert.ToInt32(qwe);
            }
            int[] feifa = new int[5000000];
            string[] feifa2 = new string[5000000];
            int k = 0;
            for (int i = 1; i < sm.Length; ++i)
            {
                if (sm[i].Length < 1) continue;
                int temp = Convert.ToInt32(sm[i]);
                if (find(temp, array) == -1)
                    feifa[k++]=temp;
            }
            DateTime afterDT = System.DateTime.Now;
            for (int t = 0; t < feifa.Length; t++)
                feifa2[t] = feifa[t].ToString();
            File.WriteAllLines("output", feifa2, Encoding.UTF8); 
            TimeSpan ts = afterDT.Subtract(beforDT);
            Console.WriteLine("DateTime: {0}ms.", ts.TotalMilliseconds);
        }
        static int find(int key, int[] array)
        {
            for (int j = 0; j < 10; j++)
            {
                if (key == array[j])
                    return key;
            }
            return -1;
        }
    }
}