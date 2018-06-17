using System.Linq;
using System.Web.Mvc;
using SpotifyAPI.Web.Models;
using TrackRecommender.Helpers;
using TrackRecommender.Models;

namespace TrackRecommender.Controllers
{
    public class TracksController : Controller
    {
        public ActionResult Tracks()
        {
            return View();
        }

        // Post: Tracks
        [HttpPost]
        public ActionResult Tracks(FormModel model)
        {
            var spotifyApi = new SpotifyIntegration.SpotifyIntegration();
            var tracksModel = new TracksModel();
            if (model.Name != null && model.Name.ToLower() == "tom araya")
            {
                tracksModel.TrackList = spotifyApi.GetSingleTrack("4Yx9Tw9dTgQ8eGCq3PRDyn");
            }
            else
            {
                var targetTrack = new TuneableTrack()
                {
                    Valence = model.Valence / 100,
                    Danceability = model.FeelLikeDancing / 100,
                };

                if (model.SelectedGenres.Length + model.SelectedArtists.Length + model.SelectedTracks.Length > 5)
                {
                    model.Genres = FormModelListItemHelper.GetGenres();
                    model.Tracks = FormModelListItemHelper.GetTracks();
                    model.Artists = FormModelListItemHelper.GetArtists();
                    model.ErrorMessage =
                        "Whoops, according to Spotify you can only select a total of 5 tracks, genres and artists for recommendations. Deselect a few and try again and sorry for the inconvenience.";
                    return View("~/Views/Genre/Genre.cshtml", model); //RedirectToRoute("Genre", model);
                }

                tracksModel.TrackList = spotifyApi.GetRecommendations(
                    artists: model.SelectedArtists.ToList(),
                    tracks: model.SelectedTracks.ToList(),
                    genres: model.SelectedGenres.ToList(),
                    targetTrack: targetTrack);
            }

            return View(tracksModel);
        }
    }
}