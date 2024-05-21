using AnimkuListu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anilist.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(50)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(6)]
        public string Rating { get; set; }

        public string YouTubeVideoId { get; set; }

        public string ImageUrl { get; set; }

        // Lista bohaterów przypisanych do filmu
        public List<Character> Characters { get; set; }
      
    }
}
