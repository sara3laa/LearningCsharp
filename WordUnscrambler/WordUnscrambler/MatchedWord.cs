using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
  public struct MatchedWord
    {
        public string ScrambledWord { get; set; }
        public string Word { get; set; }
    }
}
