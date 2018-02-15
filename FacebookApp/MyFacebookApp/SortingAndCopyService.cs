using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp
{
    public static class SortingAndCopyService
    {
        public static List<Page> SortPages(FacebookObjectCollection<Page> i_Pages)
        {
            List<Page> pages = CopyPagesToList(i_Pages);
            
            pages.Sort(delegate(Page page1, Page page2) { return page1.Name.CompareTo(page2.Name); });

            return pages;
        }

        public static List<Album> SortAlbums(FacebookObjectCollection<Album> i_Albums)
        {
            List<Album> albums = CopyAlbumsToList(i_Albums);

            albums.Sort(delegate(Album album1, Album album2) { return album1.Name.CompareTo(album2.Name); });

            return albums;
        }

        public static List<Page> CopyPagesToList(FacebookObjectCollection<Page> i_CopyFromPages)
        {
            List<Page> copyPagesList = new List<Page>();

            foreach (Page page in i_CopyFromPages)
            {
                copyPagesList.Add(page);
            }

            return copyPagesList;
        }

        public static List<Album> CopyAlbumsToList(FacebookObjectCollection<Album> i_CopyFromAlbums)
        {
            List<Album> copyAlbumsList = new List<Album>();

            foreach (Album album in i_CopyFromAlbums)
            {
                copyAlbumsList.Add(album);
            }

            return copyAlbumsList;
        }
    }
}