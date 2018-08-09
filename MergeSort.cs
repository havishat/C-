using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
    }



    static void MergeSort(string[] a)
    {
        MergeHelper(a, 0, a.Length);
    }

    static void MergeHelper(string[] a, int first, int count)
    {
        if(count == 1)
        {
            return;
        }
        if(count == 2)
        {
            if(a[first].CompareTo(a[first+1]) > 0)
            {
                string temp = a[first];
                a[first] = a[first + 1];
                a[frist + 1] = temp;
            }
            return;
        }
        MergeHelper(a, first, count / 2);
        MergeHelper(a, first + count / 2, count - count / 2);

        // Zipper
        string[] zipper = new stirng[count];
        int z = 0;
        int i = first;
        int j = first + count / 2;
        while(i < first + count /2 && j < first + count)
        {
            if (a[i].CompareTo(a[j]) < 0)
            {
                zipper[z++] == a[i++];
            } else
            {
                zipper[z++] = a[j++];
            }
        }
    }
}