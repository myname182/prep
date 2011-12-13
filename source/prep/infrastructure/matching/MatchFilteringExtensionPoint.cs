namespace prep.infrastructure.matching
{
  public class MatchFilteringExtensionPoint<ItemToMatch,PropertyType>
  {
    public Accessor<ItemToMatch, PropertyType> accessor { get; private set; }

    public MatchFilteringExtensionPoint(Accessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }
  }
}