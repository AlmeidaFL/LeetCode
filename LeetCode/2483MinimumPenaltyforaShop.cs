namespace LeetCode;

public class MinimumPenaltyforaShop2483 {
    public int BestClosingTime(string customers)
    {
        var penalty = 0;
        var maxPenalty = 0;
        var hour = -1;

        for (var i = 0; i < customers.Length; i++)
        {
            var customer = customers[i];
            penalty += customer == 'Y' ? 1 : -1;
            if (penalty <= maxPenalty) continue;
            maxPenalty = penalty;
            hour = i;
        }

        return hour + 1;
    }
}