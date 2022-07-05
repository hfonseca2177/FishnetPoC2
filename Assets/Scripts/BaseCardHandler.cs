
/*
 * Basic card implementation that resolves a card behavior
 */

namespace E4E
{
    public class BaseCardHandler : ICardHandler
    {
        public int GetBuff()
        {
            throw new System.NotImplementedException();
        }

        public int GetDamage()
        {
            throw new System.NotImplementedException();
        }

        public int GetMitigationPercentage()
        {
            throw new System.NotImplementedException();
        }

        public int GetMove()
        {
            throw new System.NotImplementedException();
        }

        public Card Resolve(Card otherCard)
        {
            throw new System.NotImplementedException();
        }
    }
}
