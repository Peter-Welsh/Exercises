// https://leetcode.com/problems/integer-to-roman/description
namespace Exercises.Solutions.Array_or_String;

public class IntegerToRoman
{
    public string IntToRoman(int num)
    {
        string[] m = ["", "M", "MM", "MMM"];
        string[] c = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"];
        string[] x = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"];
        string[] i = ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"];
        const int mVal = 1000;
        const int cVal = 100;
        const int xVal = 10;
        var thousands = m[num / mVal];
        var hundreds = c[num % mVal / cVal];
        var tens = x[num % cVal / xVal];
        var ones = i[num % xVal];
        return $"{thousands}{hundreds}{tens}{ones}";
    }
}