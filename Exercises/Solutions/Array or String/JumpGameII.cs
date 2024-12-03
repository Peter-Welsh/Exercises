// https://leetcode.com/problems/jump-game-ii/description
namespace Exercises.Solutions.Array_or_String;

public class JumpGameII
{
    public int Jump(int[] nums)
    {
        var minJumps = 0;
        var near = 0;
        var far = 0;
        while (far < nums.Length - 1)
        {
            var farthest = 0;
            for (var i = near; i <= far; i++)
            {
                farthest = Math.Max(i + nums[i], farthest);
            }
            near = far + 1;
            far = farthest;
            minJumps++;
        }
        return minJumps;
    }
}