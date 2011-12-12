namespace prep.infrastructure.matching
{
  public static class MatchExtensions
  {
    public static IMatchA<Item> or<Item>(this IMatchA<Item> left, IMatchA<Item> right)
    {
      return new OrMatch<Item>(left, right);
    }

    public static IMatchA<Item> as_specification<Item>(this Condition<Item> condition)
    {
      return new AnonymousMatch<Item>(condition);
    }
  }
}