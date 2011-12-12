using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return this.movies;
    }

    public void add(Movie movie)
    {
     // throw new NotImplementedException();
        if (!movies.Contains(movie))
        {
            foreach (var movie1 in movies)
            {
                if (movie1.isSimilar(movie))
                    return;
            }
            movies.Add(movie);
        }
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      //throw new NotImplementedException();
        List<Movie> lmovies = new List<Movie>(movies);
        return lmovies.FindAll(delegate(Movie movie)
                                   {
                                       return movie.production_studio == ProductionStudio.Pixar;
                                   }
            );

    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      //throw new NotImplementedException();
        List<Movie> lmovies = new List<Movie>(movies);
        return lmovies.FindAll(delegate(Movie movie)
                                   {
                                       if (movie.production_studio == ProductionStudio.Pixar || movie.production_studio == ProductionStudio.Disney)
                                           return true;
                                       else
                                           return false;
                                   }
            );
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_action_movies()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}