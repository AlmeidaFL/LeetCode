namespace LeetCode;

public class ContainsDuplicateII219 {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var window = new HashSet<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (window.Contains(num))
            {
                return true;
            }
            
            window.Add(num);

            if (window.Count > k)
            {
                window.Remove(nums[i - k]);
            }
        }
        
        return false;
    }
}