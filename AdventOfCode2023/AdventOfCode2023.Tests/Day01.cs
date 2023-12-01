using AdventOfCode.Interfaces;
using AdventOfCode2023.Common;
using AdventOfCode2023.Day01;

namespace AdventOfCode2023.Tests;

public class Day01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Task1Predefined()
    {
        IContentParser contentParser = new PredefinedContentParserTask1();

        IDailyTask<long> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(142));
    }
    
    [Test]
    public void Task1()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<long> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(54597));
    }
    
    [Test]
    public void Task2Predefined()
    {
        IContentParser contentParser = new PredefinedContentParserTask2();

        IDailyTask<long> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(281));
    }
    
    [Test]
    public void Task2()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<long> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(54504));
    }

    internal class PredefinedContentParserTask1 : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
                    {
                        "1abc2","pqr3stu8vwx","a1b2c3d4e5f","treb7uchet"

                    };
        }
    }

    internal class PredefinedContentParserTask2 : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
                    {
                        "two1nine","eightwothree","abcone2threexyz","xtwone3four","4nineeightseven2","zoneight234","7pqrstsixteen"

                    };
        }
    }


}