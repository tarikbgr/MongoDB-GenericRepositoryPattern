using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Entities.Concrete
{
    public class County : BaseModel
    {
       
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PostCode { get; set; }

    }
}
