using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anilist.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public string AvatarUrl { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }


    }
}
