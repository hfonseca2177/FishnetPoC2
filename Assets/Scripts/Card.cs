using System;
using UnityEngine;

/*
 * Card definition
 */
namespace E4E
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

