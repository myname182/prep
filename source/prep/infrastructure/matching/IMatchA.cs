namespace prep.infrastructure.matching
{
  public interface IMatchA<Item>
  {
    bool matches(Item item);
  }
}