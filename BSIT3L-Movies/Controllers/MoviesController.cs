using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
             new MovieViewModel { Id = 1, Name = "John Wick: Chapter 4", Rating = "7.8/10", ReleaseYear = 2023, Genre = "Action", YouTubeVideoId = "qEVUtrk8_B4", Details = "Super-assassin John Wick is on the run after killing a member of the international assassin's guild. With a $14 million price tag on his head, he is the target of hitmen and women everywhere. John must fight his way through a host of enemies as he seeks a way out of New York City.", ImageUrl = "https://drive.google.com/uc?id=1MJ6zAz8h3yismew7TER9Ra6CQ9euXgwC\r\n" },
            new MovieViewModel { Id = 2, Name = "Uncharted", Rating = "6.5/10", ReleaseYear = 2022, Genre = "Adventure", YouTubeVideoId = "eHp3MbsCbMg", Details = "Nathan Drake and his wisecracking partner Victor 'Sully' Sullivan embark on a dangerous quest to find the greatest treasure never found while escaping a ruthless mercenary. They travel the world, facing numerous obstacles and uncovering ancient secrets.", ImageUrl = "https://drive.google.com/uc?id=1I3j-ShIYvZZNPPDbKiHRe_eOtcsDXd-q\r\n" },
            new MovieViewModel { Id = 3, Name = "Blockout", Rating = "8.9/10", ReleaseYear = 2023, Genre = "Thriller", YouTubeVideoId = "QP3sxps6k0s", Details = "In a world plunged into darkness, a group of survivors must navigate a post-apocalyptic landscape filled with unknown threats. Their struggle for survival leads them to a mysterious source of light that could change everything.", ImageUrl = "https://drive.google.com/uc?id=1gL_UoKo1xjM1hwXCNT_Md7wsQmj_HjF7\r\n" },
            new MovieViewModel { Id = 4, Name = "Morbius", Rating = "6.2/10", ReleaseYear = 2022, Genre = "Action", YouTubeVideoId = "oZ6iiRrz1SY", Details = "Dr. Michael Morbius, a brilliant scientist, attempts to cure his rare blood disease but inadvertently transforms himself into a living vampire. As he grapples with his new identity and abilities, he must confront the consequences of his actions.", ImageUrl = "https://drive.google.com/uc?id=1V8Uv-7HOkXRi8WVYlRxL-BIPeUbXGFsP\r\n" },
            new MovieViewModel { Id = 5, Name = "The Adam Project", Rating = "7.1/10", ReleaseYear = 2022, Genre = "Sci-Fi", YouTubeVideoId = "IE8HIsIrq4o", Details = "A time-traveling pilot named Adam Reed crash-lands in his past. He meets his younger self and together with his younger self's family, they embark on a mission to save the future. The journey involves adventure, self-discovery, and the pursuit of redemption.", ImageUrl = "https://drive.google.com/uc?id=1B23B3fBjV-lRrZYRhMFy39aGJM9_XQoR\r\n" },
            new MovieViewModel { Id = 6, Name = "The Gray Man", Rating = "8.0/10", ReleaseYear = 2023, Genre = "Action", YouTubeVideoId = "BmllggGO4pM", Details = "A former CIA operative, Court Gentry, is pursued by his former friend and fellow assassin, Lloyd Hansen, in a deadly game of cat and mouse. The high-stakes action thriller leads to a global conspiracy and intense battles.", ImageUrl = "https://drive.google.com/uc?id=1M6ZNaalfK7hPUQwMh7mVGQaUyfGSiH25\r\n" },
            new MovieViewModel { Id = 7, Name = "Spider-Man: No Way Home", Rating = "8.5/10", ReleaseYear = 2021, Genre = "Action", YouTubeVideoId = "JfVOs4VSpmA", Details = "Peter Parker's identity as Spider-Man is exposed, causing chaos and bringing villains from other dimensions into his world. With the help of other Spider-People, Peter faces his greatest challenge yet in a multiverse-shattering battle.", ImageUrl = "https://drive.google.com/uc?id=1p-GTtYakHZOzIFJQ66LNjgBluY5SE-kg\r\n" },
            new MovieViewModel { Id = 8, Name = "The Batman", Rating = "8.0/10", ReleaseYear = 2022, Genre = "Action", YouTubeVideoId = "mqqft2x_Aa4", Details = "Bruce Wayne, as Batman, investigates a series of murders in Gotham City. His quest reveals a conspiracy that involves iconic villains like the Riddler and the Penguin. As the dark knight confronts his own demons, he strives to save the city.", ImageUrl = "https://drive.google.com/uc?id=18sqsd20npznpF4KfIiXb4Aws_yHeFIoY\n" },
            new MovieViewModel { Id = 9, Name = "Black Crab", Rating = "7.5/10", ReleaseYear = 2023, Genre = "Drama", YouTubeVideoId = "fmjKsL_-rfw", Details = "In a post-apocalyptic world, a woman named Carl Hamilton leads a group of soldiers on a mission to transport a mysterious cargo. They face extreme danger, ruthless enemies, and personal trials as they journey through a devastated landscape.", ImageUrl = "https://drive.google.com/uc?id=1DFqPaVkHd69s9bvb1aLqhcOExtPuwxDX\r\n" },
            new MovieViewModel { Id = 10, Name = "Carter", Rating = "9.5/10", ReleaseYear = 2023, Genre = "Thriller", YouTubeVideoId = "ulPHag30btQ", Details = "Carter, a skilled thief, plans a heist that takes an unexpected turn. Pursued by law enforcement and criminals, he must outsmart them to secure a valuable prize. The suspenseful thriller is filled with unexpected twists.", ImageUrl = "https://drive.google.com/uc?id=1y9xOBMQnd_fsMTdubAppfKBPiyBD0v_G\r\n" },
            new MovieViewModel { Id = 11, Name = "The Flash", Rating = "8.5/10", ReleaseYear = 2023, Genre = "Action", YouTubeVideoId = "hebWYacbdvc", Details = "Barry Allen, the Flash, faces a new threat as he navigates the multiverse. He encounters alternate versions of himself and familiar foes, leading to an epic battle to save reality. The superhero's speed and determination are put to the test.", ImageUrl = "https://drive.google.com/uc?id=1j5IG_ARJFLyjJmSVAMrP8s81E3VCUArW\r\n" },
            new MovieViewModel { Id = 12, Name = "Dune", Rating = "8.3/10", ReleaseYear = 2021, Genre = "Sci-Fi", YouTubeVideoId = "n9xhJrPXop4", Details = "In a distant future, Paul Atreides, a young nobleman, becomes embroiled in a power struggle over the desert planet Arrakis, the only source of a valuable resource. As he navigates political intrigue and battles fierce foes, Paul's destiny unfolds.", ImageUrl = "https://drive.google.com/uc?id=1U8j27f2IKqoJZFuJ_CHb29uzVoRrisg0\r\n" },
            new MovieViewModel { Id = 13, Name = "Transformers", Rating = "6.2/10", ReleaseYear = 2007, Genre = "Action", YouTubeVideoId = "itnqEauWQZM", Details = "The war between the Autobots and Decepticons, two factions of shape-shifting alien robots, arrives on Earth. Young Sam Witwicky becomes entangled in their conflict, leading to epic battles and the revelation of Earth's secret history.", ImageUrl = "https://drive.google.com/uc?id=1cFjYhIYOH3k08xTfcY_y95KOAFvbV4j-\r\n" },
            new MovieViewModel { Id = 14, Name = "Free Guy", Rating = "7.3/10", ReleaseYear = 2021, Genre = "Action", YouTubeVideoId = "JORN2hkXLyM", Details = "Guy, a non-playable character in an open-world video game, becomes self-aware and decides to be the hero of his own story. He embarks on a journey to save the game world, encountering players, chaos, and humor along the way. As he breaks free from his pre-programmed existence, he finds love and uncovers the game's sinister corporate plot.", ImageUrl = "https://drive.google.com/uc?id=1YtMkZUOPBK_fixPyN8bV-PT3_FTAzVSs\r\n" },
           new MovieViewModel { Id = 15, Name = "Snake Eyes", Rating = "5.5/10", ReleaseYear = 2021, Genre = "Action", YouTubeVideoId = "Vd2sm63Xwfw", Details = "Snake Eyes, a talented loner with a troubled past, joins an ancient Japanese clan known as the Arashikage. He forms a close bond with Storm Shadow but becomes entangled in a power struggle within the clan. The film explores his journey to become the iconic ninja warrior and the sacrifices made along the way.",ImageUrl = "https://drive.google.com/uc?id=1MBpi38OrgWHbBZvKjIzibdNazMaFRBgG\r\n" },

            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

