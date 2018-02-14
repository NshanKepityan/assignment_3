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
                Console.WriteLine("input an integer number for array's count");
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
            Dictionary<string, double> about = new Dictionary<string, double>();
            
            for (int i = 0; i<res.Length; i++)
            {
                if(res[i] == '6')
                {
                    watch.Reset();
                    watch.Start();
                    Insertion.Insertion.Sort(arr);
                    watch.Stop();
                    elapsedTime[0] = watch.ElapsedMilliseconds;
                    about.Add("insertion",watch.ElapsedMilliseconds);

                    watch.Start();
                    Bubble.Bubble.Sort(arr);
                    watch.Stop();
                    elapsedTime[1] = watch.ElapsedMilliseconds;
                    about.Add("bubble", watch.ElapsedMilliseconds);


                    watch.Start();
                    Quick.Quick.Sort(arr);
                    watch.Stop();
                    elapsedTime[2] = watch.ElapsedMilliseconds;
                    about.Add("quick", watch.ElapsedMilliseconds);

                    watch.Start();
                    Heap.Heap.Sort(arr);
                    watch.Stop();
                    elapsedTime[3] = watch.ElapsedMilliseconds;
                    about.Add("heap", watch.ElapsedMilliseconds);

                    watch.Start();
                    Merge.Merge.Sort(arr);
                    watch.Stop();
                    elapsedTime[4] = watch.ElapsedMilliseconds;
                    about.Add("merge", watch.ElapsedMilliseconds);
                    break;
                }
              switch(res[i])
                {
                    case '1':
                     watch.Start();
                     Insertion.Insertion.Sort(arr);
                     watch.Stop();
                     elapsedTime[0] = watch.ElapsedMilliseconds;
                     about.Add("insertion", watch.ElapsedMilliseconds);
                     break;
                    case '2':
                     watch.Start();
                     Bubble.Bubble.Sort(arr);
                     watch.Stop();
                     elapsedTime[1] = watch.ElapsedMilliseconds;
                     about.Add("bubble", watch.ElapsedMilliseconds);
                     break;
                    case '3':
                     watch.Start();
                     Quick.Quick.Sort(arr);
                     watch.Stop();
                     elapsedTime[2] = watch.ElapsedMilliseconds;
                     about.Add("quick", watch.ElapsedMilliseconds);
                        break;
                    case '4':
                     watch.Start();
                     Heap.Heap.Sort(arr);
                     watch.Stop();
                     elapsedTime[3] = watch.ElapsedMilliseconds;
                        about.Add("heap", watch.ElapsedMilliseconds);
                        break;
                    case '5':
                     watch.Start();
                     Merge.Merge.Sort(arr);
                     watch.Stop();
                     elapsedTime[4] = watch.ElapsedMilliseconds;
                        about.Add("merge", watch.ElapsedMilliseconds);
                        break;
                }
            }
            double min = -1.0;
            foreach (double value in elapsedTime)
            {
                if (min == -1.0)
                    min = value;
                else if (value < min)
                    min = value;
            }
            
            if(about.ContainsKey("insertion"))
            {
                if(about["insertion"] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;   // setting consoles color green 
                    Console.WriteLine("\nInsertion Sort");          
                    Console.WriteLine("Running time: {0}", about["insertion"]); 
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);           
                    Console.ForegroundColor = ConsoleColor.White;   // setting consoles color back to white 
                }
                else
                {
                    Console.WriteLine("\nInsertion Sort");      
                    Console.WriteLine("Running time: {0}", about["insertion"]);
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);
                }
            }

            if (about.ContainsKey("bubble"))
            {
                if (about["bubble"] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;   
                    Console.WriteLine("\nBubble Sort");          
                    Console.WriteLine("Running time: {0}", about["bubble"]); 
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);          
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("\nInsertion Sort");
                    Console.WriteLine("Running time: {0}", about["bubble"]);
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);
                }
            }

            if (about.ContainsKey("quick"))
            {
                if (about["quick"] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine("\nQuick Sort");         
                    Console.WriteLine("Running time: {0}", about["quick"]); 
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);         
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("\nQuick Sort");
                    Console.WriteLine("Running time: {0}", about["quick"]);
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);
                }
            }

            if (about.ContainsKey("heap"))
            {
                if (about["heap"] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;  
                    Console.WriteLine("\nHeap Sort");         
                    Console.WriteLine("Running time: {0}", about["heap"]); 
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);         
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("\nHeap Sort");
                    Console.WriteLine("Running time: {0}", about["heap"]);
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length);
                }
            }

            if (about.ContainsKey("merge"))
            {
                if (about["merge"] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;  
                    Console.WriteLine("\nMerge Sort");         
                    Console.WriteLine("Running time: {0}", about["merge"]); 
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int)*arr.Length*2);           
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("\nMerge Sort");
                    Console.WriteLine("Running time: {0}", about["merge"]);
                    Console.WriteLine("Memory usage: {0} byte", sizeof(int) * arr.Length*2);
                }
            }
        }
    }
}
