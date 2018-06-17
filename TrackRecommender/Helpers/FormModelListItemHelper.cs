using System.Collections.Generic;
using System.Web.Mvc;

namespace TrackRecommender.Helpers
{
    public static class FormModelListItemHelper
    {
        public static List<SelectListItem> GetArtists()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Selected = false,
                    Text = "Adam Beyer",
                    Value = "1btv9qmIpbp7q1ixCYNdHu"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Dead Prez",
                    Value = "2UBt0GWBuPVXlPisRvWzlD"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Slayer",
                    Value = "1IQ2e1buppatiN1bxUVkrk"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Felix Da House Cat",
                    Value = "4rC8J4M4aOqsQSCP4yoyJI"
                }
            };
        }

        public static List<SelectListItem> GetGenres()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Selected = false,
                    Text = "Techno",
                    Value = "techno"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Hip hop",
                    Value = "hip-hop"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Metal",
                    Value = "metal"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Chicago House",
                    Value = "chicago-house"
                }
            };
        }

        public static List<SelectListItem> GetTracks()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Selected = false,
                    Text = "Adam Beyer - Capsule",
                    Value = "0OUU3JfuXy4bU18ROT5AED"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Dead Prez - Hip Hop",
                    Value = "2HoDr1yVksl19omOhc1zWy"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Slayer - Raining Blood",
                    Value = "4Yx9Tw9dTgQ8eGCq3PRDyn"
                },
                new SelectListItem
                {
                    Selected = false,
                    Text = "Felix Da House Cat - Ready to wear",
                    Value = "6r0Ryr7Retl1BpvBDmgAGD"
                }
            };
        }
    }
}