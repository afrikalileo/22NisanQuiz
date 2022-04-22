using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz;

public class SongManager : BaseModel, ISample
{
    public SongManager(Song song)

    {
        this.song=song
    }
    public string FinalPlayedSongDate(ISample song)
    {
        var datemethod = song.LastPlayedDt.ToString("dd, MMMM,yyyy");
        return datemethod;
    }
    public void PlayedSong(ICal ontrack)
    {
        Console.WriteLine(song.Name)
            ontrack.ICal(song)
    }

}