using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MercuryWebParserClient.Logic
{
    //"<([a-z]+)[> ]"
    class HtmlTagsCounter
    {
        private readonly Dictionary<string, int> _numbersOfTagOccurences;
        private readonly RegexUtil _regexUtil;

        public HtmlTagsCounter(RegexUtil regexUtil1)
        {
            _regexUtil = regexUtil1;
            _numbersOfTagOccurences = new Dictionary<string, int>();
        }

        public void CountTagOccurences(string content)
        {
            var matches = _regexUtil.GetMatches(content);
            foreach (var match in matches)
            {
                var tagLength = (match as Match).Value.Length - 2;
                var tag = (match as Match).Value.Substring(1, tagLength);
                if (_numbersOfTagOccurences.ContainsKey(tag))
                {
                    _numbersOfTagOccurences[tag]++;
                }
                else
                {
                    _numbersOfTagOccurences.Add(tag, 1);
                }
            }
        }
    }
}
