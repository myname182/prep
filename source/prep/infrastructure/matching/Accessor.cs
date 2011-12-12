namespace prep.infrastructure.matching
{
  public delegate PropertyType Accessor<in Item, out PropertyType>(Item item);
}