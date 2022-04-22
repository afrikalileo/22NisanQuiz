using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz
{
    public class Album : BaseModel
    {
        public string AlbumsName { get; set; }
        public List<Song> InnerAlbum { get; set; }
        public int CountofSongs { get; }

        public Singer InnerAlbumSinger { get; set; }

        public string DesingofAlbums { get; set; }

    }
}
