namespace prep.infrastructure.matching
{
  public static class AccessorExtensions
  {
    public static IMatchA<ItemToMatch> equal_to<ItemToMatch, PropertyType>(
      this Accessor<ItemToMatch, PropertyType> accessor, PropertyType value)
    {
      return new AnonymousMatch<ItemToMatch>(x => );
    }
  }
}