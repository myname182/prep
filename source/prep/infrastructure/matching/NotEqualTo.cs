namespace prep.infrastructure.matching
{
    public class NotEqualTo<Item> : IMatchA<Item>
    {
        IMatchA<Item> item;

        public NotEqualTo(IMatchA<Item> item)
        {
            this.item = item;
        }

        public bool matches(Item item)
        {
            return !this.item.matches(item);
        }
    }
}