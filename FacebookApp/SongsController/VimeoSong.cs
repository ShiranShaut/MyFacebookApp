using System.Text;

namespace PlaylistController
{
    public class VimeoSong : Song
    {
        private readonly string r_VideoWatchUrl = "https://vimeo.com/search?q=";
        private readonly string r_VideoEmbedUrl = "https://player.vimeo.com/video/";
        private readonly string r_AutoPlayVideo = "?autoplay=1";

        public VimeoSong(string i_Link, string i_Name)
            : base(i_Link, i_Name)
        {
        }

        public override string embedVideoUrl(string i_Url)
        {
            StringBuilder videoUrl = new StringBuilder();
            string videoId = extractVideoIdFromUrl(i_Url);

            videoUrl.Append(r_VideoEmbedUrl);
            videoUrl.Append(videoId);
            videoUrl.Append(r_AutoPlayVideo);

            return videoUrl.ToString();
        }

        protected override string extractVideoIdFromUrl(string i_Url)
        {
            string[] splitUrl = i_Url.Split(new char[] { '\\' });

            return splitUrl[splitUrl.Length - 1];
        }

        public override string GetVideoUrl(string i_SongName)
        {
            StringBuilder videoUrl = new StringBuilder();
            string[] splitName = i_SongName.Split(new char[] { ' ' });

            videoUrl.Append(r_VideoWatchUrl);
            for (int i = 0; i < splitName.Length - 1; ++i)
            {
                videoUrl.Append(splitName[i] + "+");
            }

            videoUrl.Append(splitName[splitName.Length - 1]);
            m_SongLink = videoUrl.ToString();

            return videoUrl.ToString();
        }
    }
}