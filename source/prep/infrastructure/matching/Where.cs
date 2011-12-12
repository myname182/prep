namespace prep.infrastructure.matching
{
  public class Where<ItemToMatch>
  {
    public static Accessor<ItemToMatch, PropertyType> has_a<PropertyType>(Accessor<ItemToMatch, PropertyType> accessor)
    {
      return accessor;
    }
  }
}