namespace prep.infrastructure
{
  public interface IMatchA<Item>
  {
    bool matches(Item item);
  }
}