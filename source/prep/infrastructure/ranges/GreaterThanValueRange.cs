using System;

namespace prep.infrastructure.ranges
{
  public class GreaterThanValueRange<T> : Range<T> where T : IComparable<T>
  {
    T start;

    public GreaterThanValueRange(T start)
    {
      this.start = start;
    }

    public bool contains(T value)
    {
      return value.CompareTo(start) > 0;
    }
  }
}