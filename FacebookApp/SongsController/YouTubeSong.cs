using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace PlaylistController
{
    public class YouTubeSong : Song
    {
        private const string k_YoutubeApiKey = "AIzaSyBqNz8UaFGO76jJuIoSqWRO2TSH3t4oAPs";
        private readonly string r_VideoWatchUrl = "https://www.youtube.com/watch?v=";
        private readonly string r_VideoEmbedUrl = "http://www.youtube.com/v/";

        public YouTubeSong(string i_Link, string i_Name)
            : base(i_Link, i_Name)
        {
        }

        public override string embedVideoUrl(string i_Url)
        {
            return i_Url;
        }

        protected override string extractVideoIdFromUrl(string i_Url)
        {
            int i = i_Url.IndexOf("v=");

            return i_Url.Substring(i + 2);
        }

        public override string GetVideoUrl(string i_SongName)
        {
            YouTubeService youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApplicationName = this.GetType().ToString(),
                ApiKey = k_YoutubeApiKey,
            });
            SearchResource.ListRequest listRequest = youtubeService.Search.List("snippet");

            listRequest.Q = i_SongName;
            listRequest.MaxResults = 1;
            listRequest.Type = "video";
            SearchListResponse resp = listRequest.Execute();
            string videoUrl = r_VideoWatchUrl + resp.Items[0].Id.VideoId;

            m_SongLink = videoUrl;

            return videoUrl;
        }
    }
}