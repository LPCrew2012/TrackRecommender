using System.Web.Mvc;
using TrackRecommender.Helpers;
using TrackRecommender.Models;

namespace TrackRecommender.Controllers
{
    public class GenreController : Controller
    {
        // GET: Genre
        public ActionResult Genre()
        {
            var model = new FormModel()
            {
                SelectedGenres = new [] { "techno" },
                Genres = FormModelListItemHelper.GetGenres(),
                SelectedArtists = new [] { "1btv9qmIpbp7q1ixCYNdHu" },
                Artists = FormModelListItemHelper.GetArtists(),
                SelectedTracks = new[] { "0OUU3JfuXy4bU18ROT5AED" },
                Tracks = FormModelListItemHelper.GetTracks()
            };
            return View(model);
        }
    }
}