namespace prep.infrastructure.matching
{
  public class NeverMatches<ItemToMatch> : IMatchA<ItemToMatch>
  {
    public bool matches(ItemToMatch item)
    {
      return false;
    }
  }
}