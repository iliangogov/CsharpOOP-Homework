using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtentionMethod
{
   public static class IEnumerableExtantions
    {
        public static T Sum<T>(IEnumerable<T> collection)
        {
            dynamic sum =0;

            foreach (var item in collection)
            {
                dynamic element = item;

                sum += element;
            }

            return sum;
        }

        public static T Average<T>(IEnumerable<T> collection)
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                dynamic element = item;

                sum += element;
            }

            return sum / collection.Count();
        }

        public static T Product<T>(IEnumerable<T> collection)
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                dynamic element = item;

                sum *= element;
            }

            return sum;
        }

        public static T Min<T>(IEnumerable<T> collection)
        {
            dynamic min = collection.ElementAt(0);

            foreach (var item in collection)
            {
                dynamic element = item;

                if (min > element)
                    min = element;
            }

            return min;
        }

        public static T Max<T>(IEnumerable<T> collection)
        {
            dynamic max = collection.ElementAt(0);

            foreach (var item in collection)
            {
                dynamic element = item;

                if (max < element)
                    max = element;
            }

            return max;
        }
      
        public static void numsInArrayDivisBy3and7(int[]arr) //LINQ
        {
            var output = arr
               .Where(number => number % 7 == 0 && number % 3 == 0)
               .ToArray();

            Console.WriteLine(string.Join(", ", output));
        }

        public static void numsInArrayDivisBy3and7LAMBDA(int[] arr) //Lamda
        {
            var output = from num in arr
                         where num%7==0 &&num%3==0
                         select num;


            Console.WriteLine(string.Join(", ", output));
        }
    }
}
