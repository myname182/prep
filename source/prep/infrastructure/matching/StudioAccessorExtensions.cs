namespace prep.infrastructure.matching
{
    using prep.collections;

    public static class StudioAccessorExtensions
    {
        public static IMatchA<Movie> equal_to(this StudioAccessor studioAccessor, ProductionStudio other)
        {
            return new AnonymousMatch<Movie>(x => x.production_studio == other);
        }
    }
}