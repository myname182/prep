﻿using System;

namespace prep.infrastructure.matching
{
  public class ComparableMatchFactory<ItemToMatch, PropertyType> where PropertyType : IComparable<PropertyType>
  {
    Accessor<ItemToMatch, PropertyType> accessor;

    public ComparableMatchFactory(Accessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchA<ItemToMatch> greater_than(PropertyType value)
    {
        return new AnonymousMatch<ItemToMatch>(x => accessor(x).CompareTo(value) > 0);
    }
  }
}