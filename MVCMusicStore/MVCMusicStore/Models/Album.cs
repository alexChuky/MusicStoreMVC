using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCMusicStore.Models
{
    public class Album
    {

        public int AlbumID { get; set; }
        public String Titulo { get; set; }
        public Artista Artista { get; set; }
        public virtual List<Review> Reviews  { get; set; }

    }
}
