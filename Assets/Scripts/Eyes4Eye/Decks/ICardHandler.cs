/*
 * CardHandler implementation contract
 */
namespace Eyes4Eye.Decks
{
    public interface ICardHandler
    {
        Card Resolve(Card otherCard);
        int GetDamage();

        int GetBuff();

        int GetMitigationPercentage();

        int GetMove();
    }
}
