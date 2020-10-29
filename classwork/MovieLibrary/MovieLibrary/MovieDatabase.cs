using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieLibrary
{
    //Interfaces appear on the same line as base types but ARE NOT base types
    //MovieDatabase implements IMovieDatabase
    // A type can implement any # of interfaces
    // All members on an interface must be public and implemented

    //Abstract class required if any member is abstract
    //  1. Cannot be instantiated
    //  2. Must derive from it
    //  3. Must implement all abstract members

    /// <summary>Provides a base implementation of <see cref="IMovieDatabase"/>.</summary>
    public abstract class MovieDatabase : IMovieDatabase //, IEditableDatabase, IReadableDatabase
    {
        //Default constructor to seed database
        protected MovieDatabase ()
        {
            //Not needed here - clears all items from list
            //_movies.Clear();

            //Collection initializer syntax
            var items = new[] { //new Movie[] {
                new Movie() {
                    Name = "Jaws",
                    ReleaseYear = 1977,
                    RunLength = 190,
                    Description = "Shark movie",
                    IsClassic = true,
                    Rating = "PG",  // Can have a comma at end
                },
                new Movie() {
                    Name = "Jaws 2",
                    ReleaseYear = 1979,
                    RunLength = 195,
                    Description = "Shark movie",
                    IsClassic = true,
                    Rating = "PG-13",
                },
                new Movie() {
                    Name = "Dune",
                    ReleaseYear = 1985,
                    RunLength = 220,
                    Description = "Based on book",
                    IsClassic = true,
                    Rating = "PG",
                }
            };
            foreach (var item in items)
                Add(item, out var error);

            //Seed database
            // Object initializer - only usable on new operator
            //   Limitations:
            //      1. Can only set properties with setters
            //      2. Can set properties that are themselves new'ed up but cannot set child properties
            //                    Position = new Position() { Name = "Boss" };  //Allowed
            //                    Position.Title = "Boss";  //Not allowed
            //      3. Properties cannot rely on other properties
            //               Description = "blah",
            //               FullDescription = Description
            //var movie = new Movie();
            //movie.Name = "Jaws";
            //movie.ReleaseYear = 1977;
            //movie.RunLength = 190;
            //movie.Description = "Shark movie";
            //movie.IsClassic = true;
            //movie.Rating = "PG";
            //var movie = new Movie() {
            //    Name = "Jaws",
            //    ReleaseYear = 1977,
            //    RunLength = 190,
            //    Description = "Shark movie",
            //    IsClassic = true,
            //    Rating = "PG",  // Can have a comma at end
            //};
            //Add(movie, out var error);

            //movie = new Movie() {
            //    Name = "Jaws 2",
            //    ReleaseYear = 1979,
            //    RunLength = 195,
            //    Description = "Shark movie",
            //    IsClassic = true,
            //    Rating = "PG-13",
            //};
            //Add(movie, out error);

            //movie = new Movie() {
            //    Name = "Dune",
            //    ReleaseYear = 1985,
            //    RunLength = 220,
            //    Description = "Based on book",
            //    IsClassic = true,
            //    Rating = "PG",
            //};
            //Add(movie, out error);
        }

        //Not on interface
        public void Foo () { }

        /// <inheritdoc />
        public Movie Add ( Movie movie, out string error )
        {
            //TODO: Movie is not null

            //Movie is valid
            var results = new ObjectValidator().TryValidateFullObject(movie);
            if (results.Count() > 0)
            {
                foreach (var result in results)
                {
                    error = result.ErrorMessage;
                    return null;
                };
            };

            // Movie name is unique
            var existing = GetByName(movie.Name);
            if (existing != null)
            {
                error = "Movie must be unique";
                return null;
            };

            error = null;
            return AddCore(movie);
        }

        /// <inheritdoc />
        public void Delete ( int id )
        {
            //TODO: Validate Id >= 0

            DeleteCore(id);
        }

        //Use IEnumerable<T> for readonly lists of items
        //public Movie[] GetAll ()

        /// <inheritdoc />
        public IEnumerable<Movie> GetAll ()
        {
            return GetAllCore();
        }

        /// <inheritdoc />
        public Movie Get ( int id )
        {
            //TODO: id >= 0

            return GetByIdCore(id);
        }

        private Movie GetById ( int id )
        {
            // foreach (var id in array) S
            //for (var index = 0; index < _movies.Length; ++index)
            foreach (var movie in _movies)
            {
                //movie == _movies[index]
                // Restrictions:
                //   1. movie is readonly   // movie = new Movie();
                //   2. _movies cannot change, immutable 
                if (movie?.Id == id)  // null conditional ?. if instance != null access the member                
                    return movie;
            };

            return null;
        }

        /// <inheritdoc />
        public string Update ( int id, Movie movie )
        {
            //TODO: id >= 0
            //TODO: Movie is not null

            //Movie is valid
            var results = new ObjectValidator().TryValidateFullObject(movie);
            if (results.Count() > 0)
            {
                foreach (var result in results)
                {
                    return result.ErrorMessage;
                };
            };

            // Movie name is unique
            var existing = GetByName(movie.Name);
            if (existing != null && existing.Id != id)
                return "Movie must be unique";

            UpdateCore(id, movie);

            return "";
        }

        /// <summary>Adds a movie to the database.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected abstract Movie AddCore ( Movie movie );

        protected abstract void DeleteCore ( int id );

        /// <summary>Finds a movie by name.</summary>
        /// <param name="name">The movie to find.</param>
        /// <returns>The movie, if found.</returns>
        /// <remarks>
        /// The default implementation enumerates all the movies looking for a match.
        /// </remarks>
        protected virtual Movie GetByName ( string name )
        {
            foreach (var movie in GetAll())
            {
                if (String.Compare(movie.Name, name, true) == 0)
                    return movie;
            };

            return null;
        }

        protected abstract IEnumerable<Movie> GetAllCore ();

        protected abstract Movie GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, Movie movie );

        // Non-generic
        //    ArrayList - list of objects
        // Generic Types
        //    List<T> where T is any type
    }
}
