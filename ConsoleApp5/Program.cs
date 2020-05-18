using System;
using static System.Convert;
using static System.Console;
using System.Collections;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add('L');
            list.Add(54);
            list.Add('O');
            list.Add(5);
            list.Add('b');
            list.Add(64);
            list.Add(-98);
            list.Add(0);
            list.Add('V');
            list.Add(99);
            list.Add('x');
            list.Add(9);
            list.Add(2);
            list.Add('E');

            ArrayList list2 = new ArrayList();
            WriteLine("Chisla: ");
            for (int i = 0; i < list.Count; i++)
            {
                int n = 0;
                string k = list[i] + "";
                bool r = int.TryParse(k, out n); ;

                if (r == false)
                {
                    if (k == k.ToUpper())
                    {
                        list2.Add(list[i]);
                        list.RemoveAt(i);
                    }
                    else list.RemoveAt(i);
                }
            }
            foreach (object o in list)
            {
                WriteLine(o);
            }
            WriteLine("Zaglavnyye bykvy: ");
            foreach (object o in list2)
            {
                WriteLine(o);
            }
            ReadLine();
        }
    }
}

        
    

