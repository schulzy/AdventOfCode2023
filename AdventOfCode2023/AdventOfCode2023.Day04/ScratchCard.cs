using System.Collections;

namespace AdventOfCode2023.Day04;

public class ScratchCard(int cardId, IList<int> winningNumbers, IList<int> ownedNumbers)
{
    public int CardId { get; private set; } = cardId;
    public IList<int> WinningNumbers { get; private set; } = winningNumbers;
    public IList<int> OwnedNumbers { get; private set; } = ownedNumbers;
}