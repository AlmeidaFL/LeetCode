namespace LeetCode;

public class RemoveElement27
{
    public static int RemoveElement(int[] nums, int val) {
        var numberOfDifferentVal = 0;
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == val){
                nums[i] = -1;
                continue;
            }
            numberOfDifferentVal++;
        }

        var pointerLeft = 0;
        var pointerRight = nums.Length-1;
        for (int i = nums.Length; i > 0; i--){
            if(nums[pointerLeft] == -1 && nums[pointerRight] != -1){
                nums[pointerLeft] = nums[pointerRight];
                pointerLeft++;
                pointerRight--;
            }
            
            if (pointerLeft >= pointerRight)
            {
                break;
            }
            
            if(nums[pointerLeft] != -1){
                pointerLeft++;
            }

            if(nums[pointerRight] == -1){
                pointerRight--;
            }
        }

        return numberOfDifferentVal;
    }
}