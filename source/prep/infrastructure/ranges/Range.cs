using System;

namespace prep.infrastructure.ranges
{
  public interface Range<T> where T : IComparable<T>
  {
    bool contains(T value);
  }
}