//using System;

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string word = Console.ReadLine();
//            ReverseString rev = new ReverseString();
//            string revword = rev.Reverse(word);
//            Console.WriteLine(revword);
//        }
//    }
//    public class ReverseString
//    {
//        public string Reverse(string s)
//        {
//            char[] charArray = s.ToCharArray();
//            string result = string.Empty;
//            for (int i = charArray.Length - 1; i >= 0; i--)
//            {
//                result += charArray[i];
//            }
//            return result;
//        }
//    }
using System;
//public class Nee
//{
//    public static void Main(string[] args)
//    {
//        int[] numbers = new int[5];
//        int length = numbers.Length;
//        int low = int.MaxValue;
//        for (int i = 0; i < length; i++)
//        {
//            numbers[i] = int.Parse(Console.ReadLine());
//            if (numbers[i] < low)
//            {
//                low = numbers[i];
//            }
//        }
//        //for (int i = 0; i < length; i++)
//        //{

//        //}

//        Console.WriteLine(low);
//    }
//}


//public class Prime {
//    public static void Main(string[] args) { 
//       int num = int.Parse(Console.ReadLine());
//        int flag = 1;
//        if (num == 0|| num==1) {
//            Console.WriteLine("number is not prime");
//            flag = 0;
//        }
//        for(int i=2; i < num/2; i++)
//        {
//            if (num % i == 0)
//            {
//                Console.WriteLine("number is not prime");
//                flag = 0;
//                break;
//            }

//        }
//        if (flag == 1)
//        {
//            Console.WriteLine("number is prime");
//        }
//        //else
//        //{
//        //    Console.WriteLine("number is not prime");
//        //}

//    }
//}


//public class Palin
//{
//    public static void Main(string[] args)
//    {
//        string ? input=Console.ReadLine();
//        if (input == null)
//        {
//            Console.WriteLine("can't be null");
//            return;
//        }
//        string rev = input.ToLower();
//        char[] charArray = rev.ToCharArray();
//        string result = string.Empty;

//        for (int i = charArray.Length - 1; i >= 0; i--)
//        {
//            result += charArray[i];
//        }
//        if (rev == result)
//        {
//            Console.WriteLine("palindrome");
//        }
//        else
//        {
//            Console.WriteLine("not palindrome");
//        }
//    }
//}


//public class NoPalin
//{
//    public static void Main(string[] args)
//    {
//        string ? input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input))
//        {
//            Console.WriteLine("can't be null");
//            return;
//        }
//        int num= int.Parse(input);
//        int rem;
//        int sum = 0;
//        int temp = num;
//        while (num > 0)
//        {
//            rem = num % 10;
//            sum = (sum * 10) + rem;
//            num /= 10;
//        }
//        if (temp==sum)
//        {
//            Console.WriteLine($"{temp} is palindrome");
//        }
//        else
//        {
//            Console.WriteLine($"{temp} is not palindrome");
//        }
//    }
//}
//using System.Text;
//namespace ConsoleApp2
//{
//    public class Sentence
//    {
//        public bool IsPalindrome(string str)
//        {
//            StringBuilder s = new StringBuilder();
//            foreach (char ch in str)
//            {
//                if (char.IsLetterOrDigit(ch))
//                {
//                    s.Append(char.ToLower(ch));
//                }
//            }

//            string s1 = s.ToString();
//            char[] charArray = s1.ToCharArray().Reverse().ToArray();
//            string rev = new string(charArray);
//            return rev == s1;
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = Console.ReadLine();
//            Sentence sen = new Sentence();
//            Console.WriteLine(sen.IsPalindrome(str) ? "Palindrome" : "Not a Palindrome");
//        }

//    }
//}

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    public class Man : Person
//    {
//        public string Hobby { get; set; }
//    }

//    public class Class1
//    {
//        public static void Main(string[] args)
//        {
//            Object obj = new Object();
//            obj = 10; // Boxing

//            int i = (int)obj; // Unboxing
//            ArrayList arrayList = new ArrayList();

//            arrayList.Add(10);// Boxing
//            int firstElement = (int)arrayList[0]; // Unboxing

//            List<int> list = new List<int>();

//            Object myObject = new object();
//            myObject = 10;
//            myObject = "Srikanth";

//            int x = (int)myObject;

//            if (myObject is int)
//            {
//                //int myInt = (int)myObject;
//                //int myInt = Convert.ToInt32(myObject)
//                //int myInt = myObject as int; // this is only for reference type
//                Person person = new Person();
//                Man man = new Man();
//                person = man;

//                Man man2 = new Man();
//                man2 = person as Man;
//            }
//            else if (myObject is string)
//            {
//                string myString = (string)myObject;
//            }
//        }
//    }
//}


try
{
    int num = int.Parse(Console.ReadLine());
    int flag = 1;
    if(!int.TryParse(Console.ReadLine(), out num))
    {
        throw new FormatException("Invalid input");
    }
    if (num == 0 || num == 1)
    {
        Console.WriteLine("number is not prime");
        flag = 0;
    }
    for (int i = 2; i < num / 2; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine("number is not prime");
            flag = 0;
            break;
        }
    }
    if (flag == 1)
    {
        Console.WriteLine("number is prime");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("finally block");
}
//try
//{

//     ar[1000] = "error msg";
//}

int[] a = new int[5];
string s;
int aa = int.MaxValue;
try
{
    checked
    {
        aa+= 10;
        //a[10000] = 10;
        s = Console.ReadLine();
        s += 10;
    }
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (System.ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (System.FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (System.OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("finally block");
}
