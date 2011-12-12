namespace prep.infrastructure
{
    public class MatchAAdapter<item> : IMatchA<item>
    {
        private Condition<item> condition;

        public MatchAAdapter(Condition<item> condition)
        {
            this.condition = condition;
        }

        public bool matches(item item)
        {
           return condition(item);
        }
    }
}