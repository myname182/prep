namespace prep.infrastructure.matching
{
  public class MatchFilteringExtensionPoint<ItemToMatch,PropertyType>
  {
    public bool negate { get; private set; }
    public Accessor<ItemToMatch, PropertyType> accessor { get; private set; }

    public MatchFilteringExtensionPoint<ItemToMatch,PropertyType> not
    {
      get
      {
        negate = true;
          return this;
      }
    }


    public MatchFilteringExtensionPoint(Accessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }
  }
}