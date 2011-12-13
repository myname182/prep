namespace prep.infrastructure.matching
{
  public class Where<ItemToMatch>
  {
    public static MatchFilteringExtensionPoint<ItemToMatch, PropertyType> has_a<PropertyType>(
      Accessor<ItemToMatch, PropertyType> accessor)
    {
      return new MatchFilteringExtensionPoint<ItemToMatch, PropertyType>(accessor);
    }
  }
}