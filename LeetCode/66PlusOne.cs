namespace LeetCode;

public class PlusOne66 {
    public int[] PlusOne(int[] digits) {
        if (digits[^1] != 9)
        {
            digits[^1] += 1; 
            return digits;
        }
        
        var newDigits = new Stack<int>();
        var carryOut = 1;
        
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var newNumber = (digits[i] + carryOut) % 10;
            newDigits.Push(newNumber);

            carryOut = (digits[i] + carryOut)/ 10;
        }

        
        var result = newDigits.ToArray();
        if (result[0] == 0)
        {
            return [carryOut, ..result[0..result.Length]];
        }
        
        result[0] += carryOut; 
        return result;
    }
}