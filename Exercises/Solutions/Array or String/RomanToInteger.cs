// https://leetcode.com/problems/roman-to-integer/description
namespace Exercises.Solutions.Array_or_String;

public class RomanToInteger
{
    public int RomanToInt(string s)
    {
        var result = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var numeralValue = GetNumeralValue(s[i]);
            if (i + 1 < s.Length && ShouldSubtractValue(s[i], s[i + 1]))
                numeralValue *= -1;
            result += numeralValue;
        }
        return result;
    }
    
    private static bool ShouldSubtractValue(char numeral, char nextNumeral)
        => (numeral == 'I' && nextNumeral is 'V' or 'X')
        || (numeral == 'X' && nextNumeral is 'L' or 'C')
        || (numeral == 'C' && nextNumeral is 'D' or 'M');

    private static int GetNumeralValue(char numeral)
        => numeral switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => throw new ArgumentOutOfRangeException(nameof(numeral), numeral, null)
        };
}