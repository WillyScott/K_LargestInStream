using System;
using System.Collections.Generic;
using System.Linq;


namespace K_LargestInStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] temp = { 4, 5, 8, 2 };

            //KthLargest kth = new KthLargest(3, temp);
            //Console.WriteLine(kth.Add(3));
            //Console.WriteLine(kth.Add(5));
            //Console.WriteLine(kth.Add(10));
            //Console.WriteLine(kth.Add(9));
            //Console.WriteLine(kth.Add(4));

            //// [[1,[]],[-3],[-2],[-4],[0],[4]]
            //int[] temp2 = { };
            //KthLargest kth2 = new KthLargest(1, temp2);

            //Console.WriteLine(kth2.Add(-3));
            //Console.WriteLine(kth2.Add(-2));
            //Console.WriteLine(kth2.Add(-4));
            //Console.WriteLine(kth2.Add(0));
            //Console.WriteLine(kth2.Add(4));


            //[[2,[0]],[-1],[1],[-2],[-4],[3]]
            int[] temp3 = { 0 };
            KthLargest kth3 = new KthLargest(2, temp3);
            Console.WriteLine(kth3.Add(-1));
            Console.WriteLine(kth3.Add(1));
            Console.WriteLine(kth3.Add(-2));
            Console.WriteLine(kth3.Add(-4));
            Console.WriteLine(kth3.Add(3));

            Console.ReadLine();
        }
    }



    public class KthLargest
    {
        private int _k;
        private List<int> listNumbers = new List<int>();
        
               
        public KthLargest(int k, int[] nums)
        {
            _k = k;
            listNumbers = nums.ToList();
            listNumbers.Sort();
        }

        public int Add(int val)
        {
            if (listNumbers.Count < _k)
            {
                if (listNumbers.Count == 0)
                {
                    listNumbers.Add(val);
                    return val;
                }
                else
                {
                    if (val <= listNumbers.First())
                    {
                        return val;
                    }
                    else
                    {
                        // add value to end and sort
                        listNumbers.Add(val);
                        listNumbers.Sort();
                        int temp = listNumbers.Count() - _k;
                        return listNumbers[temp];
                    }
                }

            }
            else
            {
                int temp = listNumbers.Count() - _k;
                if (val <= listNumbers[temp])
                {
                    return listNumbers[temp];
                }
                else  // need to insert the larger value and sort
                {
                    listNumbers.Add(val);
                    listNumbers.Sort();
                    temp = listNumbers.Count() - _k;
                    return listNumbers[temp];

                }

            }
        }
    }
}
