/*
 * ITSE 1430
 * Michael Taylor
 * Classwork
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.WebHost.Models
{
    public class MovieModel // : IValidatableObject
    {
        public MovieModel ()
        { }

        public MovieModel ( Movie movie )
        {
            //Transform from business object to model
            Id = movie.Id;
            Name = movie.Name;
            Description = movie.Description;
            Rating = movie.Rating;
            RunLength = movie.RunLength;
            ReleaseYear = movie.ReleaseYear;
            IsClassic = movie.IsClassic;
        }

        public Movie ToMovie ()
        {
            return new Movie() {
                Id = Id,
                Name = Name,
                Description = Description,
                Rating = Rating,
                RunLength = RunLength,
                ReleaseYear = ReleaseYear,
                IsClassic = IsClassic,
            };
        }

        //Metadata - data about data

        public int Id { get; set; }

        //Attributes are metadata 
        // [][]- multiple attributes
        // [XAttribute()], [XAttribute], [X]
        // Attribute may be limited to certain types or members

        // Required - value cannot be null
        //[RequiredAttribute()]
        //[RequiredAttribute]
        [Required(AllowEmptyStrings = false)]
        [StringLength(Movie.MaximumNameLength)]
        public string Name { get; set; }

        [StringLength(Movie.MaximumNameLength)]
        public string Description { get; set; }

        public string Rating { get; set; }

        //Range enforces a min, max value
        [DisplayName("Run Length")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Run length must be greater than or equal to 0.")]
        public int RunLength { get; set; }

        [DisplayName("Release Year")]
        [Range(1900, 2100)]
        public int ReleaseYear { get; set; }

        [DisplayName("Is Classic")]
        public bool IsClassic { get; set; }
    }
}
