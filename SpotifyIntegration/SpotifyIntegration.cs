using System.Collections.Generic;
using System.Linq;
using SpotifyAPI;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;

namespace SpotifyIntegration
{
    public class SpotifyIntegration
    {
        private const string ClientId = "996d0037680544c987287a9b0470fdbb";
        private const string ClientSecret = "5a3c92099a324b8f9e45d77e919fec13";
        private Token _token;
        private SpotifyWebAPI _webApi;
        public SpotifyIntegration()
        {
            Authorize();
        }

        public void Authorize()
        {
            var auth = new ClientCredentialsAuth();
            auth.ClientId = ClientId;
            auth.ClientSecret = ClientSecret;
            _token = auth.DoAuth();
            _webApi = new SpotifyWebAPI(new ProxyConfig()) { UseAuth = true, TokenType = _token.TokenType, AccessToken = _token.AccessToken };
        }

        public SeveralTracks GetRecommendations(
            List<string> genres = null, 
            List<string> artists = null, 
            List<string> tracks = null, 
            TuneableTrack targetTrack = null)
        {
            var recommendations = _webApi.GetRecommendations(
                artistSeed: artists, 
                genreSeed: genres, 
                trackSeed: tracks, 
                target: targetTrack,
                limit: 25, 
                market: "SE");

            var trackIdList = recommendations.Tracks.Select(t => t.Id).ToList();

            return _webApi.GetSeveralTracks(trackIdList);
        }

        public SeveralTracks GetSingleTrack(string trackId)
        {
            return new SeveralTracks() {Tracks = new List<FullTrack>() { _webApi.GetTrack(trackId) } };
        }
    }
}
