using AdventOfCode.Interfaces;

namespace AdventOfCode2023.Day01;

public class Task1(IContentParser contentParser) : IDailyTask<long>
{
    private readonly IContentParser _contentParser = contentParser;

    public long Run()
    {
        var twoDigitsCleaner = new TwoDigitsCleaner(_contentParser.GetLines("Task.txt"));
        var list = twoDigitsCleaner.CleanDocument();
        return list.Sum(int.Parse);
    }

    public string Name => "Trebuchet?!";
}