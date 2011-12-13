namespace prep.infrastructure.matching
{
  public class MatchFactory<ItemToMatch, PropertyType> : ICreateMatchers<ItemToMatch, PropertyType>
  {
    Accessor<ItemToMatch, PropertyType> accessor;

    public MatchFactory(Accessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchA<ItemToMatch> equal_to(PropertyType value)
    {
      return equal_to_any(value);
    }

    public IMatchA<ItemToMatch> create_from(IMatchA<PropertyType> value_criteria)
    {
      return new PropertyMatch<ItemToMatch, PropertyType>(accessor, value_criteria);
    }

    public IMatchA<ItemToMatch> equal_to_any(params PropertyType[] values)
    {
      return create_from(new IsEqualToAny<PropertyType>(values));
    }

    public IMatchA<ItemToMatch> not_equal_to(PropertyType value)
    {
      return equal_to(value).not();
    }
  }
}