using System;

namespace prep.infrastructure.ranges
{
  public class InclusiveRange<T> : Range<T> where T : IComparable<T>
  {
    T end;
    T start;

    public InclusiveRange(T end, T start)
    {
      this.end = end;
      this.start = start;
    }

    public bool contains(T value)
    {
      return value.CompareTo(start) >= 0 && value.CompareTo(end) <= 0;
    }
  }
}