namespace prep.infrastructure.matching
{
  public class NegatingMatchFilteringExtensionPoint<ItemToMatch,PropertyType> : IProvideAccessToFilteringExtensions<ItemToMatch,PropertyType>
  {
    IProvideAccessToFilteringExtensions<ItemToMatch, PropertyType> original;

    public NegatingMatchFilteringExtensionPoint(IProvideAccessToFilteringExtensions<ItemToMatch, PropertyType> original)
    {
      this.original = original;
    }

    public IMatchA<ItemToMatch> create_criteria_using(IMatchA<PropertyType> value_criteria)
    {
      return original.create_criteria_using(value_criteria).not();
    }
  }
}