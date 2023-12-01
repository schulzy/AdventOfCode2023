using System.Collections.Frozen;
using System.Text.RegularExpressions;

namespace AdventOfCode2023.Day01
{
    public class TwoDigitsCleaner : IDocumentCleaner
    {
        private readonly FrozenSet<string> _list;

        public TwoDigitsCleaner(IList<string> list)
        {
            _list = FrozenSet.ToFrozenSet(list);
        }

        public IList<string> CleanDocument()
        {
            IList<string> result = new List<string>();
            foreach (var item in _list)
            {
                var stripped = Regex.Replace(item, "[^0-9]", "");
                if(stripped.Length <= 0)
                    throw new ArgumentOutOfRangeException(nameof(stripped));

                result.Add($"{stripped.First()}{stripped.Last()}");
            }

            return result;
        }
    }
}
