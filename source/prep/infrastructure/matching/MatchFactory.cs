using System.Collections.Generic;

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

    public IMatchA<ItemToMatch> create_from(Condition<ItemToMatch> condition)
    {
      return new AnonymousMatch<ItemToMatch>(condition);
    }

    public IMatchA<ItemToMatch> equal_to_any(params PropertyType[] values)
    {
        return  create_from(x => new List<PropertyType>(values).Contains(accessor(x)));
    }

    public IMatchA<ItemToMatch> not_equal_to(PropertyType value)
    {
      return equal_to(value).not();
    }

  }
}