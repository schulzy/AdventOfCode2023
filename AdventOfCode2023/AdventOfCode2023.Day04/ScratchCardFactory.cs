namespace AdventOfCode2023.Day04;

public class ScratchCardFactory
{
    public ScratchCard Create(string line)
    {
        string[] card = line.Split(":");
        int cardId = int.Parse(card[0].Replace("Card", "").Trim());
        string[] numbers = card[1].Split("|");
        IList<int>  winningNumbers = GetNumberList(numbers[0].Trim());
        IList<int> ownNumbers = GetNumberList(numbers[1].Trim());

        return new ScratchCard(cardId, winningNumbers, ownNumbers);
    }

    private IList<int> GetNumberList(string numbers)
    {
        IList<int> numberList = new List<int>();
        string[] numbersArray = numbers.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in numbersArray)
        {
            numberList.Add(int.Parse(item));
        }

        return numberList;
    }
}