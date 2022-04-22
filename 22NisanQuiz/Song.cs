using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _22NisanQuiz
{
    public class Song : BaseModel, ICal
    {
        public Song(string Name)
        {
            Console.WriteLine(Name + "is name of song");    
        }
        public DateTime AnnouncementDate { get; set; }
        public DateTime ReleaseDate { get
            {
                return  DateTime.AnnouncementDate.AddDays(10);


            }
            }
        public DateTime Duration { get; set; }  

    }
}
