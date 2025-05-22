using System;
using System.Collections.Generic;

public class ItemCounter
{
    public static void CountItems<T>(List<T> items)
    {
        Dictionary<T, int> itemCounts = new Dictionary<T, int>();

        foreach (T item in items)
        {
            if (itemCounts.ContainsKey(item))
            {
                itemCounts[item]++;
            }
            else
            {
                itemCounts[item] = 1;
            }
        }

        foreach (var pair in itemCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    
    public static void Main()
    {
        List<string> sampleList = new List<string> { "blueberry", "banana", "blueberry", "orange", "banana", "blueberry" };
        CountItems(sampleList);
    }
}

