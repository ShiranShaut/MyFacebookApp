using System;

namespace PlaylistController
{
    public static class SongsFactory
    {
        public static Song CreateSong(string i_Url, string i_Name)
        {
            Song song = null;

            if (i_Url.Contains("youtube"))
            {
                song = new YouTubeSong(i_Url, i_Name);
            }

            if (i_Url.Contains("vimeo"))
            {
                song = new VimeoSong(i_Url, i_Name);
            }

            if (song == null)
            {
                throw new NullReferenceException();
            }

            return song;
        }
    }
}
