using AdventOfCode.Interfaces;

namespace AdventOfCode2023.Tests;

public class Day03
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
            return
            [
                "467..114..",
                "...*......",
                "..35..633.",
                "......#...",
                "617*......",
                ".....+.58.",
                "..592.....",
                "......755.",
                "...$.*....",
                ".664.598.."
            ];
        }
    }
}