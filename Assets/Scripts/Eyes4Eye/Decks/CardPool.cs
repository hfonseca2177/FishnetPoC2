using System.Collections.Generic;

/*
 * Collection of cards
 */
namespace Eyes4Eye.Decks
{
    public class CardPool
    {

        public List<CardVO> cards;


        public void Add(CardVO card)
        {
            cards.Add(card);
        }

        public CardVO Draw()
        {
            CardVO card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            //TODO Shuffle current pool
        }

        public void AddAndShuffle(ref CardPool cardPool)
        {
            //TODO add CardPool to current and clean other
        }
    }
}

