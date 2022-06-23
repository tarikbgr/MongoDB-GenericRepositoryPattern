using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Entities.Concrete
{
    public class WorkingHour
    {
        public ICollection<Translation> Translation { get; set; }
       
    }
}
