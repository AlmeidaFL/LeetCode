using System.Text;

namespace LeetCode;

public class Maximum60Number69 {
    public int Maximum69Number (int num)
    {
        var next6OnNumber = -1;
        var strNum = new StringBuilder(num.ToString());
        for (var i = 0; i < strNum.Length; i++)
        {
            var c = strNum[i];
            if (c != '6') continue;
            next6OnNumber = i;
            break;
        }

        var final = next6OnNumber != -1 ? strNum
            .Replace('6', '9', next6OnNumber, 1)
            .ToString()
            : strNum.ToString();
        return int.Parse(final);
    }

}