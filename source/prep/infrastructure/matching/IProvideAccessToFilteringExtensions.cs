namespace prep.infrastructure.matching
{
  public interface IProvideAccessToFilteringExtensions<ItemToMatch, PropertyType>
  {
    IMatchA<ItemToMatch> create_criteria_using(IMatchA<PropertyType> value_criteria);
  }
}