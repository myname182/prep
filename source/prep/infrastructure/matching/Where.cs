using System;

namespace prep.infrastructure.matching
{
  public class Where<ItemToMatch>
  {
    public static MatchFactory<ItemToMatch, PropertyType> has_a<PropertyType>(Accessor<ItemToMatch, PropertyType> accessor)
    {
      return new MatchFactory<ItemToMatch, PropertyType>(accessor);
    }
  }

  public class MatchFactory<ItemToMatch, PropertyType>
  {
    Accessor<ItemToMatch, PropertyType> accessor;

    public MatchFactory(Accessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchA<ItemToMatch> equal_to(PropertyType value)
    {
      return new AnonymousMatch<ItemToMatch>(x => accessor(x).Equals(value));
    }


    public IMatchA<ItemToMatch> equal_to_any(params PropertyType[] values)
    {
      throw new NotImplementedException();
    }
  }
}