// https://leetcode.com/problems/jump-game/description
namespace Exercises.Solutions.Array_or_String;

public class JumpGame
{
    public bool CanJump(int[] nums)
    {
        var goal = nums.Length - 1;
        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (i + nums[i] < goal) { continue; }
            goal = i;
        }
        return goal == 0;
    }
}