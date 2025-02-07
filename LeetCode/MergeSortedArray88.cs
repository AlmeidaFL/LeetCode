namespace LeetCode;

public class MergeSortedArray88
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var mergedList = new List<int>();
        var ponteiroArray1 = 0;
        var ponteiroArray2 = 0;

        while (true)
        {
            int? valueInArray1 = null;
            if (ponteiroArray1 < m)
            {
                valueInArray1 = nums1[ponteiroArray1];
            }

            int? valueInArray2 = null;
            if (ponteiroArray2 < n)
            {
                valueInArray2 = nums2[ponteiroArray2];
            }

            if (valueInArray1.HasValue && valueInArray2.HasValue)
            {
                if (valueInArray1 <= valueInArray2)
                {
                    mergedList.Add(nums1[ponteiroArray1]);
                    ponteiroArray1++;
                }
                else if (valueInArray2 < valueInArray1)
                {
                    mergedList.Add(nums2[ponteiroArray2]);
                    ponteiroArray2++;
                }
            }
            else if (valueInArray1.HasValue)
            {
                mergedList.Add(nums1[ponteiroArray1]);
                ponteiroArray1++;
            }
            else if (valueInArray2.HasValue)
            {
                mergedList.Add(nums2[ponteiroArray2]);
                ponteiroArray2++;
            }
            else
            {
                break;
            }
        }

        for (int i = 0; i < mergedList.Count; i++)
        {
            nums1[i] = mergedList[i];
        }
    }
}