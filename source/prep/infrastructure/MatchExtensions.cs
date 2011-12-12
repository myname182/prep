namespace prep.infrastructure
{
  public static class MatchExtensions
  {
    public static IMatchA<Item> or<Item>(this IMatchA<Item> left, IMatchA<Item> right)
    {
      return new OrMatch<Item>(left, right);
    }
  }
}