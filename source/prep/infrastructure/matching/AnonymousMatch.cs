namespace prep.infrastructure.matching
{
    public class AnonymousMatch<item> : IMatchA<item>
    {
        Condition<item> condition;

        public AnonymousMatch(Condition<item> condition)
        {
            this.condition = condition;
        }

        public bool matches(item item)
        {
           return condition(item);
        }
    }
}