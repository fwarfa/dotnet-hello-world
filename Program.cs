using System;

namespace Csharp_helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

// Problem 1 KATA Opposites attract
    public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        { 
            //Moment of truth...
        if ((flower1 % 2 == 0 & flower2 % 2 != 0) || (flower2 % 2 == 0 & flower1 % 2 != 0)) {
            if (flower1 == 0 & flower2 == 0) {
            return false;
            }
            return true;
        }
        else {
            return false;
        }
        }
    }

// Problem 2 KATA You only need one
/*

correct javascript answers

JS ANSWER 1
function valueChecker(array, value)
  {
    if (array.includes(value)) {
       return true;
    }
    else if (array.includes(value.toString())) {
      return true;
    }
    else {
       return false;
    }
}

correct js answer 2

function Check (array, value) {
   for (let i=0; i < array.length; i++) {
      if (array[i] == value) {
        console.log('value matched: ', array[i]);
        return true;
      }
    }
    return false;
}

// NOT WORKING C# Answer

public class Kata
{
  public static bool Check(object[] a, object x)
  {
    for (int i=0; i < a.Length; i++) {
      if (a[i] == x) {
        return true;
      }
    }
    return false;
  }
}
*/

//Problem 3 KATA Sum of Positives
    public class Kata
    {
    public static int PositiveSum(int[] arr)
    {
            // Your code here
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= 0) {
                    sum += arr[i];
                }
            }
            if (sum == 0) {
                return 0;
            }
            else {
                return sum;
            }
        }
    }
}