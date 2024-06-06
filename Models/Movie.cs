using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        // The question mark after string indicates that the property is nullable.
        public string? Title { get; set; }

        /*
        The DataType attribute on ReleaseDate specifies the type of the data (Date). With this attribute:

        The user isn't required to enter time information in the date field.
        Only the date is displayed, not time information.
        */
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set;}
        public string? Genre { get; set; }
        public decimal Price { get; set; }

    }
}