namespace AdventOfCode2023.Day04;

public class ScratchCard(int cardId, IList<int> winningNumbers, IList<int> ownedNumbers) 
{
    public int CardId { get; private set; } = cardId;
    public IList<int> WinningNumbers { get; private set; } = winningNumbers;
    public IList<int> OwnedNumbers { get; private set; } = ownedNumbers;

    public int Points()
    {
        int foundCounter = WinningNumberCount();
        return foundCounter == 0 ? 0 : (int)Math.Pow(2.0, foundCounter - 1);
    }

    public int WinningNumberCount()
    {
        int foundCounter = 0;
        foreach (var winningNumber in WinningNumbers)
        {
            if (OwnedNumbers.Contains(winningNumber))
                foundCounter++;
        }

        return foundCounter;
    }

    public ScratchCard Clone()
    {
        return new ScratchCard(CardId, WinningNumbers, OwnedNumbers);
    }
}