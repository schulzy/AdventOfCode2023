using AdventOfCode.Interfaces;

namespace AdventOfCode2023.Day01;

public class Task2(IContentParser contentParser) : IDailyTask<long>
{
    private readonly IContentParser _contentParser = contentParser;

    public long Run()
    {
        var twoDigitsCleaner = new StringsToDigitsCleaner(_contentParser.GetLines("Task.txt"));
        var list = new TwoDigitsCleaner(twoDigitsCleaner.CleanDocument()).CleanDocument();
        return list.Sum(int.Parse);
    }

    public string Name => "Trebuchet?! Hard";
}