using SE1611_Group3_A2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1611_Group3_A2.Controller
{
    internal class AlbumController
    {
        MusicStoreContext context = new MusicStoreContext();
        public List<Album> getAllAlbums()
        {
            return context.Albums.ToList();
        }
        public List<Album> getAlbumsByGenreId(int genreId)
        {
            return context.Albums.Where(x => x.GenreId == genreId).ToList();
        }

        public List<Album> getAlbumsByLimitOffet(int page, int genreId)
        {
            // select all
            if(genreId == 0)
            {
                return context.Albums.OrderBy(x => x.AlbumId).Skip(page * 4).Take(4).ToList();
            }
            // select genre
            else
            {
                return context.Albums.OrderBy(x => x.AlbumId).Where(x=>x.GenreId == genreId).Skip(page * 4).Take(4).ToList();
            }
        }
    }
}
