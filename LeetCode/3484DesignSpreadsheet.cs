namespace LeetCode;

public class DesignSpreadsheet3484 {
    private Dictionary<string, int> valueByCell;
    
    public DesignSpreadsheet3484(int rows) {
        valueByCell = new Dictionary<string, int>();
    }
    
    public void SetCell(string cell, int value) {
        valueByCell[cell] = value;
    }
    
    public void ResetCell(string cell) {
        valueByCell[cell] = 0;
    }
    
    public int GetValue(string formula) {
        var split = formula.Split('+');
        var formulaOne = split[0].Replace("=", "");
        int? valueOne = int.TryParse(formulaOne, out var res1) ? res1 : null;
        var formulaTwo = split[1];
        int? valueTwo = int.TryParse(formulaTwo, out var res2) ? res2 : null;
        var value1 = valueOne ?? valueByCell.GetValueOrDefault(formulaOne);
        var value2 = valueTwo ?? valueByCell.GetValueOrDefault(formulaTwo);
        return value1 + value2;
    }
}