using System.Collections.Generic;

namespace prep.infrastructure
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<Item> one_at_a_time<Item>(this IEnumerable<Item> items)
    {
      foreach (var item in items) yield return item;
    }

    public static IEnumerable<Item> all_items_matching<Item>(this IEnumerable<Item> items, IMatchA<Item> criteria)
    {
      return items.all_items_matching(criteria.matches);
    }

    static IEnumerable<Item> all_items_matching<Item>(this IEnumerable<Item> items, Condition<Item> condition)
    {
      foreach (var item in items) if (condition(item)) yield return item;
    }
  }
}