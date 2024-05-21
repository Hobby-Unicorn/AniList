using Anilist.Models;
using AnimkuListu.Models;
using System.Collections.Generic;

namespace Anilist.ViewModels
{
    public class DetailsViewModel
    {
        public Movie Movie { get; set; }
        public Character Character { get; set; }
        public List<Comment> Comments { get; set; }

        // Dodajemy pole średniej oceny
        public double? AverageRating { get; set; }
    }
}
