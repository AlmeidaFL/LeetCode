namespace LeetCode;

public class MaximumMatrixSum1975 {
    public long MaxMatrixSum(int[][] matrix)
    {
        long numberOfNegatives = 0;
        var hasZero = false;
        long minNumber = int.MinValue;
        long maxNumber = int.MaxValue;
        long totalSum = 0;
        
        foreach (var array in matrix)
        {
            foreach (var number in array)
            {
                if (number == 0)
                    hasZero = true;
                
                if (number < 0)
                    numberOfNegatives++;
                
                if (number <= 0 && number > minNumber)
                    minNumber = number;
                
                if (number >= 0 && number < maxNumber)
                    maxNumber = number;
                
                totalSum += Math.Abs(number);
            }
        }
        
        var numberNearZero = Math.Abs(minNumber) > Math.Abs(maxNumber) 
            ? Math.Abs(maxNumber) 
            : Math.Abs(minNumber);
        
        var hasEvenNumberOfNegatives = numberOfNegatives % 2 == 0;

        return hasEvenNumberOfNegatives || hasZero
            ? totalSum
            : totalSum - (Math.Abs(numberNearZero) * 2);
    }
}