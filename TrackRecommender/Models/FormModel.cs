using System.Collections.Generic;
using System.Web.Mvc;

namespace TrackRecommender.Models
{
    public class FormModel
    {
        public string Name { get; set; }

        public int Valence { get; set; }
        public int FeelLikeDancing { get; set; }

        public List<SelectListItem> Genres { get; set; }

        public string[] SelectedGenres { get; set; }

        public List<SelectListItem> Artists { get; set; }

        public string[] SelectedArtists { get; set; }

        public List<SelectListItem> Tracks { get; set; }

        public string[] SelectedTracks { get; set; }

        public string ErrorMessage { get; set; }
    }
}