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
            int[] array = new int[9000000];
            string qwe;
            for (int i = 0; ; i++)
            {
                qwe = Console.ReadLine();
                if (qwe.Length < 1) break;   //遇空退出
                array[i] = Convert.ToInt32(qwe);
            }
            string data = "";
            for (int i = 1; i < sm.Length; ++i)
            {
                if (sm[i].Length < 1) continue;
                int temp = Convert.ToInt32(sm[i]);
                if (find(temp, array) == -1)
                    data = data + Convert.ToString(temp)+"\n";  //存入字符串
            }
            Console.WriteLine(data); //输出
            DateTime afterDT = System.DateTime.Now;
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