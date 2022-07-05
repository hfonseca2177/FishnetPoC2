/*
 * CardHandler implementation contract
 */
namespace E4E
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
