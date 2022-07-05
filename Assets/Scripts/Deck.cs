using System;
using System.Collections.Generic;
using UnityEngine;

/*
 * collection of cards by role definition
 */
namespace E4E
{
    [CreateAssetMenu(fileName = "Deck", menuName = "E4E Assets/Deck")]
    [Serializable]
    public class Deck: ScriptableObject
    {
        public RoleEnum role;
        public List<Card> cards;
        
    }

}