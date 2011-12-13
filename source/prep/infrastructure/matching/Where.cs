using System;

namespace prep.infrastructure.matching
{
  public class Where<ItemToMatch>
  {
    public static MatchFactory<ItemToMatch, PropertyType> has_a<PropertyType>(
      Accessor<ItemToMatch, PropertyType> accessor)
    {
      return new MatchFactory<ItemToMatch, PropertyType>(accessor);
    }

    public static ComparableMatchFactory<ItemToMatch,PropertyType> has_an<PropertyType>(Accessor<ItemToMatch,PropertyType> accessor) where PropertyType : IComparable<PropertyType>
    {
      return new ComparableMatchFactory<ItemToMatch, PropertyType>(accessor,has_a(accessor));
    }
  }
}