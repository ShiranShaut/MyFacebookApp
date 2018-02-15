namespace PlaylistController
{
    public abstract class Song
    {
        protected readonly string r_SongName;
        protected string m_SongLink;

        public string SongLink
        {
            get { return m_SongLink; }
        }

        public string SongName
        {
            get { return r_SongName; }
        }

        public Song(string i_Link, string i_Name)
        {
            m_SongLink = embedVideoUrl(i_Link);
            r_SongName = i_Name;
        }

        protected abstract string extractVideoIdFromUrl(string i_Url);

        public abstract string embedVideoUrl(string i_Url);

        public abstract string GetVideoUrl(string i_SongName);
    }
}
