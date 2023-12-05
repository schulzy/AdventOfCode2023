namespace AdventOfCode2023.Day04
{
    public class Scratcher(List<string> lines)
    {
        private List<string> _lines = lines;
        private IList<ScratchCard> _scratchCards = new List<ScratchCard>();
        private Dictionary<int, (ScratchCard Card, int Lenght)> _scratcherDictionary = new Dictionary<int, (ScratchCard, int)>();

        public IList<ScratchCard> ScratchCards 
        { 
            get
            {
                if (_scratchCards.Count == 0)
                    InitScratchCards();
                if( _scratchCards.Count ==0 )
                    throw new ArgumentNullException(nameof(ScratchCards));

                return _scratchCards;
            } 
        }

        internal long SumOfCards()
        {
            foreach (var card in ScratchCards)
            {
                _scratcherDictionary.Add(card.CardId, new (card, 1)) ;
            }

            for (int i = 1; i <= ScratchCards.Count - 1; i++)
            {
                int winningNumber = _scratcherDictionary[i].Card.WinningNumberCount();
                for (int j = 1; j <= winningNumber; j++)
                {
                    int sum = _scratcherDictionary[i + j].Lenght + _scratcherDictionary[i].Lenght;
                    _scratcherDictionary[i + j] = (_scratcherDictionary[i + j].Card, sum);
                }
            }

            return _scratcherDictionary.Sum(x=>x.Value.Lenght);
        }

        internal long SumOfPoints()
        {
            return ScratchCards.Sum(x => x.Points());
        }

        private void InitScratchCards()
        {
            ScratchCardFactory scratchCardFactory = new ScratchCardFactory();
            _scratchCards = new List<ScratchCard>();
            foreach (var line in _lines)
            {
                _scratchCards.Add(scratchCardFactory.Create(line));
            }
        }
    }
}
