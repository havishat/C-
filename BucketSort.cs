using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        string[] array = InitialArray();
        QuickSort(array);
        Print(array, "Sorted");
    }


    //Also Called Radix Sort

    static void BucketSort(string[] a)
    {
        BucketHelper(a, 0, a.Length);
    }

    static Random rand = new Random();

    static void BucketHelper(string[] a, int index)
    {
        LinkedList<string>[] buckets = new LinkedList<string>[26];
        foreach(string s in a)
        {
            char ch = s[index];
            int radix = ch - "a";
            if(buckets[radix] == null)
            {
                buckets[radix] == new LinkedList<string>();
            }
            buckets[radix].AddLast(s);
        }
        int i = 0;
         foreach(var buck in buckets)
        {
            if(buck == null)
            {
                continue;
            }
            foreach(stirng s in buck)
            {
                a[i++] = s;
            }

        }
        Print(a, "After sorted on" + index);


    }

}