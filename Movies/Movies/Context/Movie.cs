using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Context
{
    internal class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = null!;
        public int ReleaseDate { get; set; }

        [Browsable(false)]
        public virtual ICollection<MovieGenre> MovieGenres { get; } = new List<MovieGenre>();

    }
}
