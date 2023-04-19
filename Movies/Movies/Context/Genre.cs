using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Context
{
    internal class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<MovieGenre> MovieGenres { get; } = new List<MovieGenre>();
    }
}
