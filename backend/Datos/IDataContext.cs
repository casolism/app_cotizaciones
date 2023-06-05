using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace backend.Datos
{
    public interface IDataContext
    {
        void Save<T>(T entidad) where T : class, new();
        void Update<T>(T entidad) where T : class, new();
        T GetOne<T>(Expression<Func<T, string>> propiedad, Object valor) where T : class, new();
        T GetLast<T>(Expression<Func<T, bool>> query, Expression<Func<T, string>> SortBypropiedad) where T : class, new();
        IList<T> Get<T>(string propiedad, QueryOperator Operator, Object valor) where T : class, new();
        IList<T> Get<T>(IList<Criteria> Criteria) where T : class, new();
        IList<T> Get<T>(Expression<Func<T, bool>> query) where T : class, new();
        IList<T> GetLike<T>(Expression<Func<T, string>> propiedad, Object valor) where T : class, new();
        IList<T> GetBetween<T>(Expression<Func<T, Object>> propiedad, Object valorDesde, Object valorHasta) where T : class, new();
        IList<T> GetAll<T>() where T : class, new();
        void Delete<T>(Expression<Func<T, Object>> propiedad, Object valor) where T : class, new();
        void Delete<T>(Expression<Func<T, bool>> query) where T : class, new();
        string GenerateID<T>(T entidad) where T : class, new();
    }
}