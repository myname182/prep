namespace prep.infrastructure.matching
{
  public interface IMatchA<in Item>
  {
    bool matches(Item item);
  }
}