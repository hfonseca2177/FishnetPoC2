using System;
using System.Collections.Generic;
using Eyes4Eye.Rounds;
using UnityEngine;

/*
 * collection of cards by role definition
 */
namespace Eyes4Eye.Decks
{
    [CreateAssetMenu(fileName = "Deck", menuName = "E4E Assets/Deck")]
    [Serializable]
    public class Deck: ScriptableObject
    {
        public RoleEnum role;
        public List<Card> cards;
        
    }

}