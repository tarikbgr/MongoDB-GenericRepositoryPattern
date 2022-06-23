using CarPark.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Core.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        GetManyResult<TEntity> AsQueryable();//İstediğim mongodb dökümanının listesini dönecek bütün listeyi döner
        Task<GetManyResult<TEntity>> AsQueryableAsync();
        GetManyResult<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter);// where koşulu gibi düşün (x=>x.name=="Tarık") sorgularını yapmamıza yarıyor Filtreleyerek döndürür
        Task<GetManyResult<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filter);//Sercan abiye sor
        GetOneResult<TEntity> GetById(string id); //İd ye göre getirir
        Task<GetOneResult<TEntity>> GetByIdAsync(string id);
        GetOneResult<TEntity> InsertOne(TEntity entity);//Kayıt atma metodu ekleme metodu gönderdiğim entityi databaseye kaydet
        Task<GetOneResult<TEntity>> InsertOneAsync(TEntity entity);
        GetManyResult<TEntity> InsertMany(ICollection<TEntity> entities);//Birden fazla ekleme metodu
        Task<GetManyResult<TEntity>> InsertManyAsync(ICollection<TEntity> entities);
        GetOneResult<TEntity> ReplaceOne(TEntity entity,string id);//Update işlemi değiştirme işlemi o yüzden id sinide gönderiyoruz
        Task<GetOneResult<TEntity>> ReplaceOneAsync(TEntity entity,string id);
        GetOneResult<TEntity> DeleteOne(Expression<Func<TEntity, bool>> filter);//Filtreye göre silme işlemi yapar
        Task<GetOneResult<TEntity>> DeleteOneAsync(Expression<Func<TEntity, bool>> filter);
        GetOneResult<TEntity> DeleteById(string id); //İd ye göre siler
        Task<GetOneResult<TEntity>> DeleteByIdAsync(string id);
        void DeleteMany(Expression<Func<TEntity, bool>> filter);//Birden fazla data siler
        Task DeleteManyAsync(Expression<Func<TEntity, bool>> filter);

    }
}
