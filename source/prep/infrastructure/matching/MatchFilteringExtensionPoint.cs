namespace prep.infrastructure.matching
{
  public class MatchFilteringExtensionPoint<ItemToMatch, PropertyType> : IProvideAccessToFilteringExtensions<ItemToMatch, PropertyType>
  {
    Accessor<ItemToMatch, PropertyType> accessor;

    public IProvideAccessToFilteringExtensions<ItemToMatch, PropertyType> not
    {
      get
      {
        return new NegatingMatchFilteringExtensionPoint<ItemToMatch, PropertyType>(this);
      }
    }

    public MatchFilteringExtensionPoint(Accessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchA<ItemToMatch> create_criteria_using(IMatchA<PropertyType> value_criteria)
    {
      return new PropertyMatch<ItemToMatch, PropertyType>(accessor, value_criteria);
    }
  }
}