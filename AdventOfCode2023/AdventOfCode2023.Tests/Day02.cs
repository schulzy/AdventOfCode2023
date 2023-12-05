using AdventOfCode.Interfaces;

namespace AdventOfCode2023.Tests;

public class Day02
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Task1Predefined()
    {
        Assert.Fail();
    }
    
    [Test]
    public void Task1()
    {
        Assert.Fail();
    }
    
    [Test]
    public void Task2Predefined()
    {
        Assert.Fail();
    }
    
    [Test]
    public void Task2()
    {
        Assert.Fail();
    }

    internal class PredefinedContentParser : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
                "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
                "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
                "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"

            };
        }
    }
}