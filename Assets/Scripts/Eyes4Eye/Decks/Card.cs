using System;
using Eyes4Eye.Rounds;
using UnityEngine;

/*
 * Card definition
 */
namespace Eyes4Eye.Decks
{
    [CreateAssetMenu(fileName = "Card", menuName = "E4E Assets/Card")]
    [Serializable]
    public class Card : ScriptableObject
    {
        public string cardName;
        public Sprite art;
        public CardTypeEnum type;
        public CardHandlerEnum cardHandler;
        public RoleEnum role;
        public int quantity;

    }
}

