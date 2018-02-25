namespace mbl.Data {
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using mbl.Domains;

    public class RepositoryBase<T>: IRepository<T> 
        where T : IEntityModel {
        protected IMongoCollection<T> Collection {get; set;}

        public RepositoryBase(string databaseName, string collectionName, string databaseUrl) {
            var client = new MongoClient(databaseUrl);
            var database = client.GetDatabase(databaseName);
            Collection = database.GetCollection<T>(collectionName);
        }

        public async Task<List<T>> GetAll()
        {
            var list = new List<T>();

            var allDocuments = await Collection.FindAsync(new BsonDocument());
            await allDocuments.ForEachAsync(doc => list.Add(doc));

            return list;
        }

        public T GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> GetBy_()
        {
            throw new System.NotImplementedException();
        }

        public async Task Add(T entity)
        {
            await Collection.InsertOneAsync(entity);
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}