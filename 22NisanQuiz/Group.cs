using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz
{
    public class Group : BaseModel
    {
        public Group(String Name)
        {
            Name = Name;
        }
        public DateTime EstablishmentDate { get; set; }
        public List<Singer> Participater { get; set; }

    }
}
