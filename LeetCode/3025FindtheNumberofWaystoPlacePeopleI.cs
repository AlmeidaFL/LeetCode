namespace LeetCode;

public class FindtheNumberofWaystoPlacePeopleI3025 {
    public int NumberOfPairs(int[][] points) {
        var numberOfPairs = new HashSet<((int,int), (int,int))>();

        foreach (var pointComparisionA in points)
        {
            foreach (var pointComparisionB in points)
            {
                var (aX, aY) = (pointComparisionA[0], pointComparisionA[1]);
                var (bX, bY) = (pointComparisionB[0], pointComparisionB[1]);

                if ((aX > bX || aY < bY)
                    || aX == bX && aY == bY)
                {
                    continue;
                }

                var theresPointInside = false;
                foreach (var pointInside in points)
                {
                    var (cX, cY) = (pointInside[0], pointInside[1]);

                    // Preventing check 'isOnBorder' on the comparision pair
                    if ((cX == aX && cY == aY) || (cX == bX && cY == bY)) continue;
                    
                    var isMiddleXCross = cX >= aX && cX <= bX;
                    var isMiddleYCross = (cY <= aY && cY >= bY) || (cY >= aY && cY <= bY);
                    // var isOnBorder = cX < bX && cX == aX // left
                    //                  || cX < bX && cY == bY // bottom
                    //                  || cX < bX && cY == aY // top
                    //                  || cX > aX && cX == bX; // right
                    if ((isMiddleXCross && isMiddleYCross))
                    {
                        theresPointInside = true;
                        break;
                    }
                }

                if (theresPointInside) continue;
                
                numberOfPairs.Add(((aX, aY), (bX, bY)));
            }
        }

        return numberOfPairs.Count;
    }
}