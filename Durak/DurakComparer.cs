using CardLib;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Durak
{
    internal class DurakComparer : IComparer<Card>
    {
        private CardSuit trump;

        public DurakComparer(CardSuit suit)
        {
            this.trump = suit;
        }

        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            if (x.Suit == trump ^ y.Suit == trump)
                return x.Suit == trump ? 1 : -1;
            return x.Rank == y.Rank ? x.Rank.CompareTo(y.Rank) : x.Suit.CompareTo(y.Suit);
        }
    }
}