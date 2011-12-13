using System;

namespace prep.infrastructure.matching
{
  public class ComparableMatchFactory<ItemToMatch, PropertyType> : ICreateMatchers<ItemToMatch, PropertyType>
    where PropertyType : IComparable<PropertyType>
  {
    Accessor<ItemToMatch, PropertyType> accessor;
    ICreateMatchers<ItemToMatch, PropertyType> original;

    public ComparableMatchFactory(Accessor<ItemToMatch, PropertyType> accessor,
                                  ICreateMatchers<ItemToMatch, PropertyType> original)
    {
      this.accessor = accessor;
      this.original = original;
    }

    public IMatchA<ItemToMatch> equal_to(PropertyType value)
    {
      return original.equal_to(value);
    }

    public IMatchA<ItemToMatch> equal_to_any(params PropertyType[] values)
    {
      return original.equal_to_any(values);
    }

    public IMatchA<ItemToMatch> not_equal_to(PropertyType value)
    {
      return original.not_equal_to(value);
    }

    public IMatchA<ItemToMatch> create_from(Condition<ItemToMatch> condition)
    {
      return original.create_from(condition);
    }

    public IMatchA<ItemToMatch> greater_than(PropertyType value)
    {
      return create_from(x => accessor(x).CompareTo(value) > 0);
    }

    public IMatchA<ItemToMatch> between(PropertyType start, PropertyType end)
    {
      return
        create_from(
          x => accessor(x).CompareTo(start) >= 0 && accessor(x).CompareTo(end) <= 0);
    }
  }
}