namespace LeetCode;

public class RemoveDuplicatesFromSortedArray26
{
    public static int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0){
            return 0;
        }
            
        var cleanerIndex = 1;
        var firstNumber = nums[0];
        var repeated = false;
        for(int i = 1; i < nums.Length; i++){
            var repeatedValue = nums[i];
            if(firstNumber == repeatedValue){
                repeated = true;
                continue;
            }
            if (firstNumber != repeatedValue && repeated){
                nums[cleanerIndex] = repeatedValue;
                cleanerIndex++;
                firstNumber = repeatedValue;
                repeated = false;
                continue;
            }
        
            firstNumber = repeatedValue;
            cleanerIndex++;
        }
        
        return cleanerIndex;
    }
}