using prep.collections;

namespace prep.infrastructure.matching
{
  public delegate ProductionStudio StudioAccessor(Movie movie);

  public class Where<ItemToMatch>
  {
    public static StudioAccessor has_a(StudioAccessor accessor)
    {
      return accessor;
    }
  }
}