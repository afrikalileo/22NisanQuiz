using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz;

public class Singer : BaseModel
{
    public Singer SingerNameandSurname (string Name, string Surname)
    {
       this.Name = Name;
       this.Surname = Surname; 

    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Country { get; set; }
    public DateTime BirthDay { get; set; }
    
    
}
