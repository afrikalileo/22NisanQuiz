using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz;
{
public class PlayList : BaseModel, ISample
{
    public List<Song> SongList { get; set; }
    public User UserPlayList { get; set; }

    public int CountofSong { get
        {
            return SongList.Count;
        }
    }
}