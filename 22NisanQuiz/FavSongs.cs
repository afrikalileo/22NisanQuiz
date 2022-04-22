using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz
{
    public class FavSongs : BaseModel
    {
        public List<Song> FavSonss { get; set; }
        public User UserFavs { get; set; }


    }
}
