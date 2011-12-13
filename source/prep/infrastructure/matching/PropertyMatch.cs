namespace prep.infrastructure.matching
{
  public class PropertyMatch<ItemToMatch,PropertyType> : IMatchA<ItemToMatch>
  {
    Accessor<ItemToMatch, PropertyType> accessor;
    IMatchA<PropertyType> real_criteria;

    public PropertyMatch(Accessor<ItemToMatch, PropertyType> accessor, IMatchA<PropertyType> real_criteria)
    {
      this.accessor = accessor;
      this.real_criteria = real_criteria;
    }

    public bool matches(ItemToMatch item)
    {
      return real_criteria.matches(accessor(item));
    }
  }
}