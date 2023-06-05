using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace backend.Datos
{
    public class MongoDbDataContext : IDataContext
    {
        private IMongoDatabase Database { get; set; }
        public MongoDbDataContext(string MongoConnection, string MongoDB)
        {
            string connectionString = MongoConnection;
            string dbName = MongoDB;
            MongoClient client;
            client = new MongoClient(connectionString);
            Database = client.GetDatabase(dbName);
        }
        public void Save<T>(T entidad) where T : class, new()
        {
            var collection = Database.GetCollection<T>(typeof(T).Name);
            GenerateIds(entidad);
            collection.InsertOne(entidad);
        }
        public void Update<T>(T entidad) where T : class, new()
        {
            Type t = entidad.GetType();
            string valor = t.GetProperties().Where(p => p.Name == "Id").ToArray()[0].GetValue(entidad, null).ToString();
            var filter = Builders<T>.Filter.Eq("Id", valor);
            var collection = Database.GetCollection<T>(typeof(T).Name);
            collection.ReplaceOne(filter, entidad);
        }
        public T GetOne<T>(Expression<Func<T, string>> propiedad, Object valor) where T : class, new()
        {
            var expression = (MemberExpression)propiedad.Body;
            string name = expression.Member.Name;
            var filter = Builders<T>.Filter.Empty;
            var collection = Database.GetCollection<T>(typeof(T).Name);
            filter = Operation(filter, new Criteria(name, QueryOperator.Equal, valor));
            return collection.Find(filter).FirstOrDefault();
        }
        public IList<T> Get<T>(IList<Criteria> Criteria) where T : class, new()
        {
            var filter = Builders<T>.Filter.Empty;
            foreach (Criteria cri in Criteria)
                filter = Operation(filter, cri);
            var collection = Database.GetCollection<T>(typeof(T).Name);
            return collection.Find(filter).ToList();
        }
        public IList<T> Get<T>(string propiedad, QueryOperator Operator, object valor) where T : class, new()
        {
            var filter = Builders<T>.Filter.Empty;
            filter = Operation(filter, new Criteria(propiedad, Operator, valor));
            var collection = Database.GetCollection<T>(typeof(T).Name);
            return collection.Find(filter).ToList();
        }
        public IList<T> Get<T>(Expression<Func<T, bool>> query) where T : class, new()
        {
            return Database.GetCollection<T>(typeof(T).Name).AsQueryable().Where(query).ToList();
        }
        public IList<T> GetLike<T>(Expression<Func<T, string>> propiedad, Object valor) where T : class, new()
        {
            var expression = (MemberExpression)propiedad.Body;
            string name = expression.Member.Name;
            var filter = Builders<T>.Filter.Regex(name, new BsonRegularExpression(valor.ToString()));
            var collection = Database.GetCollection<T>(typeof(T).Name);
            return collection.Find(filter).ToListAsync().Result;
        }

        public void Delete<T>(Expression<Func<T, Object>> propiedad, Object valor) where T : class, new()
        {
            var expression = (MemberExpression)propiedad.Body;
            string name = expression.Member.Name;
            var filter = Builders<T>.Filter.Empty;
            var collection = Database.GetCollection<T>(typeof(T).Name);
            filter = Operation(filter, new Criteria(name, QueryOperator.Equal, valor));
            collection.DeleteOne(filter);
        }
        public void Delete<T>(Expression<Func<T, bool>> query) where T : class, new()
        {
            var collection = Database.GetCollection<T>(typeof(T).Name);
            collection.DeleteMany(query);
        }
        public IList<T> GetAll<T>() where T : class, new()
        {
            var collection = Database.GetCollection<T>(typeof(T).Name);
            return collection.Find(_ => true).ToList();
        }
        public IList<T> GetBetween<T>(Expression<Func<T, object>> propiedad, object valorDesde, object valorHasta) where T : class, new()
        {
            throw new NotImplementedException();
        }
        private void GenerateIds(Object entidad)
        {
            Type t = entidad.GetType();
            t.GetProperties().Where(p => p.Name == "Id").ToArray()[0].SetValue(entidad, ObjectId.GenerateNewId().ToString(), null);
            IList<PropertyInfo> props = t.GetProperties().Where(p => p.PropertyType.Module.ScopeName != "CommonLanguageRuntimeLibrary").ToList();
            foreach (PropertyInfo p in props)
            {
                if (p.GetValue(entidad, null) == null)
                    try
                    {
                        p.PropertyType.GetProperties().Where(x => x.Name == "Id").ToArray()[0]
                                                  .SetValue(p.GetValue(entidad, null), ObjectId.GenerateNewId().ToString(), null);
                    }
                    catch (Exception) { }
            }
            IList<PropertyInfo> propsList = t.GetProperties().Where(p => p.PropertyType.Namespace == "System.Collections.Generic").ToList();
            foreach (PropertyInfo p in propsList)
            {
                try
                {
                    IList ObjListId = (IList)p.GetValue(entidad, null);
                    if (ObjListId != null)
                    {
                        foreach (var item in ObjListId)
                        {
                            IList<PropertyInfo> l = item.GetType().GetProperties().Where(n => n.Name == "Id").ToList();
                            if (l.Count > 0 && item == null)
                                l[0].SetValue(item, ObjectId.GenerateNewId().ToString(), null);
                        }
                    }
                }
                catch (Exception) { }
            }
        }
        public T GetLast<T>(Expression<Func<T, bool>> query, Expression<Func<T, string>> SortBypropiedad) where T : class, new()
        {
            var r = Database.GetCollection<T>(typeof(T).Name).AsQueryable().Where(query).OrderBy(SortBypropiedad);
            if (r != null && r.Any())
                return r.First();
            else
                return null;
        }
        private static FilterDefinition<T> Operation<T>(FilterDefinition<T> filter, Criteria criteria) where T : class, new()
        {
            if (criteria.Operator.Equals(QueryOperator.Equal))
                filter &= Builders<T>.Filter.Eq(criteria.propiedad, criteria.valor);
            if (criteria.Operator.Equals(QueryOperator.GreaterThanOrEqual))
                filter &= Builders<T>.Filter.Gte(criteria.propiedad, criteria.valor);
            if (criteria.Operator.Equals(QueryOperator.LesserThanOrEqual))
                filter &= Builders<T>.Filter.Lte(criteria.propiedad, criteria.valor);
            if (criteria.Operator.Equals(QueryOperator.NotEqual))
                filter &= Builders<T>.Filter.Ne(criteria.propiedad, criteria.valor);
            if (criteria.Operator.Equals(QueryOperator.GreaterThan))
                filter &= Builders<T>.Filter.Gt(criteria.propiedad, criteria.valor);
            if (criteria.Operator.Equals(QueryOperator.IsNotNull))
                filter &= Builders<T>.Filter.Exists(criteria.propiedad);
            if (criteria.Operator.Equals(QueryOperator.IsNull))
                filter &= Builders<T>.Filter.Exists(criteria.propiedad, false);
            if (criteria.Operator.Equals(QueryOperator.LesserThan))
                filter &= Builders<T>.Filter.Lt(criteria.propiedad, criteria.valor);
            return filter;
        }

        public string GenerateID<T>(T entidad) where T : class, new()
        {
            return ObjectId.GenerateNewId().ToString();
        }
    }
}