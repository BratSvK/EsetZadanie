using System.Collections.Generic;

namespace EsetAssignment.Helpers;

internal static class TransformExtensions
{
    public static int[] TransformNumbersInArray(this int[] items, IDictionary<int, int> translateDictionary)
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = translateDictionary[items[i]];
        }

        return items;
    } 
}

