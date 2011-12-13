using System;

namespace prep.infrastructure.matching
{
  public static class DateMatchFilteringExtensions
  {
    public static IMatchA<ItemToMatch> greater_than<ItemToMatch>(
      this MatchFilteringExtensionPoint<ItemToMatch, DateTime> extension_point,
      int year)
    {
      return extension_point.create_from(Where<DateTime>.has_a(x => x.Year).greater_than(year));
    }
  }
}