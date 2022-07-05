using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Collection of cards
 */
namespace E4E
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

