namespace TradeAndTravel
{
    using System.Linq;
    public static class PersonExtensions
    {
        public static bool HasItemInInventory(this Person actor, ItemType itemType)
        {
            return actor.ListInventory().Any(i => i.ItemType == itemType);
        }
    }
}
