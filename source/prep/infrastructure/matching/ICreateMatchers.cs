namespace prep.infrastructure.matching
{
  public interface ICreateMatchers<ItemToMatch, PropertyType>
  {
    IMatchA<ItemToMatch> equal_to(PropertyType value);
    IMatchA<ItemToMatch> equal_to_any(params PropertyType[] values);
    IMatchA<ItemToMatch> not_equal_to(PropertyType value);
    IMatchA<ItemToMatch> create_from(IMatchA<PropertyType> value_criteria);
  }
}