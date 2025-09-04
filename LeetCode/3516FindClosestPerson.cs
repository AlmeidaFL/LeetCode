namespace LeetCode;

public class FindClosestPerson3516 {
    public int FindClosest(int x, int y, int z)
    {
        var offSetX = Math.Abs(x - z);
        var offSetY = Math.Abs(y - z);

        return offSetX == offSetY
            ? 0
            : offSetX < offSetY
                ? offSetX
                : offSetY;
    }
}