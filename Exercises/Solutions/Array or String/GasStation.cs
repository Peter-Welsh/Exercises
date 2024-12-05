// https://leetcode.com/problems/gas-station/description
namespace Exercises.Solutions.Array_or_String;

public class GasStation
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var totalSurplus = 0;
        var surplus = 0;
        var start = 0;
        for (var i = 0; i < gas.Length; i++)
        {
            totalSurplus += gas[i] - cost[i];
            surplus += gas[i] - cost[i];
            if (surplus >= 0) { continue; }
            surplus = 0;
            start = i + 1;
        }
        return (totalSurplus >= 0) ? start : -1;
    }
}