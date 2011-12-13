namespace prep.infrastructure.matching
{
  public static class MatchExtensions
  {
    public static IMatchA<Item> not<Item>(this IMatchA<Item> to_negate)
    {
      return new NegatingMatch<Item>(to_negate);
    }

    public static IMatchA<Item> or<Item>(this IMatchA<Item> left, IMatchA<Item> right)
    {
      return new OrMatch<Item>(left, right);
    }
  }
}