using System.Collections.Generic;
using System;

namespace CDOrganizer.Models
{
    public class Artist
    {
        private static List<Artist> _instances = new List<Artist> { };
        private string _name;
        private int _id;
        private List<Album> _albums;
        public Artist(string ArtistName)
        {
            _name = ArtistName;
            _instances.Add(this);
            _id = _instances.Count;
            _albums = new List<Album> { };
        }
        public string GetName()
        {
            return _name;
        }
        public int GetId()
        {
            return _id;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static List<Artist> GetAll()
        {
            return _instances;
        }
        public static Artist Find(int searchId)
        {
            return _instances[searchId - 1];
        }
        public List<Album> GetAlbums()
        {
            return _albums;
        }
        public void AddAlbum(Album album)
        {
            _albums.Add(album);
        }
        public static int GetArtist(string userQuery)
        {
            int results = 0;
            for (int i = 0; i < _instances.Count; i++)
            {
                if (userQuery == _instances[i]._name)
                {
                    results = _instances[i]._id;
                }
            }
            return results;
        }
    }

}