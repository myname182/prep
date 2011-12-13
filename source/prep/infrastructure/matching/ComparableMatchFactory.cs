using System;

namespace prep.infrastructure.matching
{
  public class ComparableMatchFactory<ItemToMatch, PropertyType> : ICreateMatchers<ItemToMatch, PropertyType>
    where PropertyType : IComparable<PropertyType>
  {
    ICreateMatchers<ItemToMatch, PropertyType> original;

    public ComparableMatchFactory(ICreateMatchers<ItemToMatch, PropertyType> original)
    {
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

    public IMatchA<ItemToMatch> create_from(IMatchA<PropertyType> value_criteria)
    {
      return original.create_from(value_criteria);
    }

    public IMatchA<ItemToMatch> greater_than(PropertyType value)
    {
      //create a dsl that can be used to create ranges 
      //ex : ARange.starting_at(1).non_inclusive()
      //ex : 1.non_inclusive()
      //ex : ARange.starting_at(1).inclusive().up_to(3).inclusive()
      return create_from(new FallsInRange<PropertyType>(i_will_use_the_dsl_here_to_create_the_range));
    }

    public IMatchA<ItemToMatch> between(PropertyType start, PropertyType end)
    {
      return create_from(new FallsInRange<PropertyType>(i_will_use_the_dsl_here_to_create_the_range));
    }
  }
}