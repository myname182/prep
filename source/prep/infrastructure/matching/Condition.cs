namespace prep.infrastructure.matching
{
  public delegate bool Condition<in Item>(Item item);
}