using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Insertion;
using Bubble;
using Quick;
using Merge;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool a = false;
            Random r = new Random();
            while(!a)
            {
                Console.WriteLine("Incorrect input please input an integer number");
                String s = Console.ReadLine();
                a = Int32.TryParse(s, out count);
            }
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = r.Next();
            }
            Console.WriteLine("The generated array: [{0}]",string.Join(", ",arr));
            Console.WriteLine("Which algorithm or algorithms do you want to sort with?\n1.Insertion\n2.Bubble\n3.Quick\n4.Heap\n5.Merge\n6.all");
            String choice = Console.ReadLine();
            char[] res = new char[choice.Length];
            for(int i = 0; i<choice.Length; i++)
            {
                res[i] = choice[i];
            }
            Stopwatch watch = new Stopwatch();
            double[] elapsedTime = new double[5];
            Dictionary<string, double>[] about = new Dictionary<string, double>;
            
            for (int i = 0; i<res.Length; i++)
            {
                if(res[i] == '6')
                {
                    watch.Start();
                    Insertion.Insertion.Sort(arr);
                    watch.Stop();
                    elapsedTime[0] = watch.ElapsedMilliseconds;
                    about["insertion"] = watch.ElapsedMilliseconds;
                    watch.Start();
                    Bubble.Bubble.Sort(arr);
                    watch.Stop();
                    elapsedTime[1] = watch.ElapsedMilliseconds;

                    watch.Start();
                    Quick.Quick.Sort(arr);
                    watch.Stop();
                    elapsedTime[2] = watch.ElapsedMilliseconds;

                    watch.Start();
                    Heap.Heap.Sort(arr);
                    watch.Stop();
                    elapsedTime[3] = watch.ElapsedMilliseconds;

                    watch.Start();
                    Merge.Merge.Sort(arr);
                    watch.Stop();
                    elapsedTime[4] = watch.ElapsedMilliseconds;
                    break;
                }
              switch(res[i])
                {
                    case '1':
                     watch.Start();
                     Insertion.Insertion.Sort(arr);
                     watch.Stop();
                     elapsedTime[0] = watch.ElapsedMilliseconds;
                     break;
                    case '2':
                     watch.Start();
                     Bubble.Bubble.Sort(arr);
                     watch.Stop();
                     elapsedTime[1] = watch.ElapsedMilliseconds;
                     break;
                    case '3':
                     watch.Start();
                     Quick.Quick.Sort(arr);
                     watch.Stop();
                     elapsedTime[2] = watch.ElapsedMilliseconds;
                     break;
                    case '4':
                     watch.Start();
                     Heap.Heap.Sort(arr);
                     watch.Stop();
                     elapsedTime[3] = watch.ElapsedMilliseconds;
                     break;
                    case '5':
                     watch.Start();
                     Merge.Merge.Sort(arr);
                     watch.Stop();
                     elapsedTime[4] = watch.ElapsedMilliseconds;
                     break;
                }
            }
            foreach(double value in elapsedTime)
            Console.WriteLine(value);
        }
    }
}
