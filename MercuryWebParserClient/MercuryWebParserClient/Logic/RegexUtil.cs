using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MercuryWebParserClient.Logic
{
    class RegexUtil
    {
        private readonly Regex _regex;

        public RegexUtil(Regex regex)
        {
            _regex = regex;
        }

        public MatchCollection GetMatches(string content)
        {
            return _regex.Matches(content);
        }
    }
}
