namespace prep.infrastructure.matching
{
  public class Where<ItemToMatch>
  {
    public static MatchFactory<ItemToMatch, PropertyType> has_a<PropertyType>(
      Accessor<ItemToMatch, PropertyType> accessor)
    {
      return new MatchFactory<ItemToMatch, PropertyType>(accessor);
    }
  }
}