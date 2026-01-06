namespace LeetCode;

public class CountNegativeNumbersinaSortedMatrix1351 {
    public int CountNegatives(int[][] grid)
    {
        return CountNegativeNumbers(grid[0]);
    }

    private int CountNegativeNumbers(int[] numbers)
    {
        var leftPointer = 0;
        var rightPointer = numbers.Length - 1;

        while (leftPointer < rightPointer)
        {
            var mid = (int)Math.Ceiling((rightPointer + leftPointer) / 2.0);

            if (numbers[leftPointer] >= 0 && numbers[mid] < 0)
            {
                break;
            }
            
            if (numbers[mid] >= 0)
            {
                leftPointer = mid;
            }
            else
            {
                rightPointer = mid;
            }
        }

        if (leftPointer == rightPointer && rightPointer == 0 && numbers[leftPointer] < 0)
        {
            return numbers.Length;
        }
        if (leftPointer == rightPointer && rightPointer == 0 && numbers[leftPointer] >= 0)
        {
            return numbers.Length - 1;
        }

        if (leftPointer == rightPointer && rightPointer == numbers.Length - 1 && numbers[leftPointer] < 0)
        {
            return 1;
        }
        if (leftPointer == rightPointer && rightPointer == numbers.Length - 1 && numbers[leftPointer] >= 0)
        {
            return 0;
        }
        
        return rightPointer - leftPointer;
    }
}