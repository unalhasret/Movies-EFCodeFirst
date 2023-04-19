using Movies.Context;

namespace Movies
{
    public partial class Form1 : Form
    {
        MovieContext _context = new MovieContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Genre> genreList = _context.Genres.ToList();
            foreach (var item in genreList)
            {
                cmbGenre.Items.Add(item.GenreName);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string cmbText = cmbGenre.Text;
            var selectedMovieList = new List<Movie>();
            var genreIdList = _context.Genres.Where(x => x.GenreName == cmbText).Select(x => x.GenreId).ToList();
            var movieIdList = _context.MovieGenres.Where(x => x.GenreId == genreIdList[0]).Select(x => x.MovieId).ToList();
            foreach (var item in movieIdList)
            {
                selectedMovieList.Add(_context.Movies.FirstOrDefault(x => x.MovieId == item));
            }
            dgvMovies.DataSource = selectedMovieList;
        }

    }
}