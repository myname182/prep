namespace prep.infrastructure.matching
{
    public static class AnonymousMatchFactory<ItemToMatch>
    {
        public static IMatchA<ItemToMatch> CreateMatch(Condition<ItemToMatch> condition)
        {
            return new AnonymousMatch<ItemToMatch>(condition);
        }
    }
}