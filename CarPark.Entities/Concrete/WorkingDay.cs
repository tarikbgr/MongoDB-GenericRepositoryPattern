using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Entities.Concrete
{
   public class WorkingDay : BaseModel
    {
        
        public ICollection<Translation> Translations { get; set; }
        public ICollection<WorkingHour> WorkingHours { get; set; }
    }
}
