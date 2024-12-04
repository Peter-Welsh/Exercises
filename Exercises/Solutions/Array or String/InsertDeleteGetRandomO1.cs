// https://leetcode.com/problems/insert-delete-getrandom-o1/description
namespace Exercises.Solutions.Array_or_String;

public class InsertDeleteGetRandomO1
{
    public class RandomizedSet
    {
        private readonly Dictionary<int, int> numMap = new();
        private readonly List<int> numList = [];
        private readonly Random random = new();

        public bool Insert(int val)
        {
            if (numMap.ContainsKey(val))
            {
                return false;
            }
            numList.Add(val);
            numMap[val] = numList.Count - 1;
            return true;
        }

        public bool Remove(int val)
        {
            if (!numMap.TryGetValue(val, out var idx))
            {
                return false;
            }
            numList[idx] = numList[^1];
            numMap[numList[idx]] = idx;
            numList.RemoveAt(numList.Count - 1);
            numMap.Remove(val);
            return true;
        }

        public int GetRandom() => numList[random.Next(numList.Count)];
    }
}