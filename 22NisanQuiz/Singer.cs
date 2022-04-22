using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz
{
    public class Singer : BaseModel
    {
        public Singer SingerNameandSurname (string Name, string Surname)
        {
            Console.WriteLine(Name);
            Console.WriteLine (Surname);    

        }

        public string Country { get; set; }
        public DateTime BirthDay { get; set; }
        

    }
}
