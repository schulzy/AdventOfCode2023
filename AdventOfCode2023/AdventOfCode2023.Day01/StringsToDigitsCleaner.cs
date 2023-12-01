using System.Collections.Frozen;
using System.Text;

namespace AdventOfCode2023.Day01
{
    internal class StringsToDigitsCleaner : IDocumentCleaner
    {
        private FrozenSet<string> _list;
        private Dictionary<string, int> _digits = new Dictionary<string, int>()
        {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };

        public StringsToDigitsCleaner(IList<string> list)
        {
            _list = FrozenSet.ToFrozenSet(list);
        }

        public IList<string> CleanDocument()
        {
            IList<string> result = new List<string>();
            foreach (string item in _list)
            {
                StringBuilder stringBuilder = new StringBuilder(item);
                result.Add(FindFirstStringDigit(stringBuilder));
            }

            return result;
        }

        private string FindFirstStringDigit(StringBuilder item)
        {
            foreach (var digit in _digits)
            {
                item.Replace(digit.Key, $"{digit.Key.First()}{digit.Value}{digit.Key.Last()}");
            }

            return item.ToString();
        }
    }
}
