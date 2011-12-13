namespace prep.infrastructure.matching
{
    public class NegatingMatch<Item> : IMatchA<Item>
    {
        IMatchA<Item> item;

        public NegatingMatch(IMatchA<Item> item)
        {
            this.item = item;
        }

        public bool matches(Item item)
        {
            return !this.item.matches(item);
        }
    }
}