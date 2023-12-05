using AdventOfCode.Interfaces;

namespace AdventOfCode2023.Day04;

public class Task2(IContentParser contentParser) : IDailyTask<long>
{
    private readonly IContentParser _contentParser = contentParser;

    public long Run()
    {
        var scratcher = new Scratcher(_contentParser.GetLines("Task.txt"));
        return scratcher.SumOfCards();
    }

    public string Name => "Scratchcards Hard";
}