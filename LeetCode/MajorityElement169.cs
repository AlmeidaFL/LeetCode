namespace LeetCode;

public class MajorityElement169
{
    public int MajorityElement(int[] nums)
    {
        var frequencyByValue = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            var found = frequencyByValue.TryGetValue(num, out _);
            if (!found)
            {
                frequencyByValue.Add(num, 1);
                continue;
            }
            frequencyByValue[num] += 1;
        }
        
        var minFrequency = nums.Length / 2;
        KeyValuePair<int,int>? x = frequencyByValue.FirstOrDefault(x => x.Value > minFrequency);
        return x?.Key ?? -1;
    }
}