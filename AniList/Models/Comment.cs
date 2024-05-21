using Anilist.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace AnimkuListu.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public string Name { get; set; }

        public DateTime PostedOn { get; set; }
       
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
