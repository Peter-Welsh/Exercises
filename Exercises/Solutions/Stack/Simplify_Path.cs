// https://leetcode.com/problems/simplify-path/description
namespace Exercises.Solutions.Stack;

public class Simplify_Path
{
    public string SimplifyPath(string path)
    {
        if (path.Length <= 1) { return path; }
        var directories = new List<string>();
        var tokens = path
            .Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x != ".");
        foreach (var token in tokens)
        {
            if (token != "..")
            {
                directories.Add(token);
                continue;
            }
            if (directories.Count == 0) { continue; }
            directories.RemoveAt(directories.Count - 1);
        }
        return $"/{string.Join('/', directories)}";
    }
}