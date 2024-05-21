using Microsoft.AspNetCore.Identity;

namespace Anilist.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string UserName { get; set; }
        public IdentityUser User { get; set; }
        public Movie Movie { get; set; }

        // Dodajemy pole oceny
        public int? Rating { get; set; }
    }
}
