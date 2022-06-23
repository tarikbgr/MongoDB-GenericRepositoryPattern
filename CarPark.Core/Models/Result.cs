using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Core.Models
{
    public class Result
    {
        public Result()
        {
            Success = true;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class GetOneResult<TEntity> : Result where TEntity : class, new()//Tek data döndürür
    {
        public TEntity Entity { get; set; }
    }
    public class GetManyResult<TEntity> : Result where TEntity : class, new()//Liste döndürür
    {
        public IEnumerable<TEntity> Result { get; set; }
    } 

}
