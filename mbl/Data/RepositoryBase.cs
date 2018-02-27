namespace mbl.Data {
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using LiteDB;
    using mbl.Domains;

    public class RepositoryBase<T>: IRepository<T> 
        where T : IEntityModel {
        protected string CollectionName {get; private set;}

        protected LiteDatabase db;

        public RepositoryBase(string databaseName, string collectionName) {
            db = new LiteDatabase(databaseName);
            CollectionName = collectionName;
        }

        public IEnumerable<T> GetAll()
        {
            var list = db.GetCollection<T>(CollectionName);
            return list.FindAll();
        }

        public T GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetBy_()
        {
            throw new System.NotImplementedException();
        }

        public void Add(T entity)
        {
            var list = db.GetCollection<T>(CollectionName);
            list.Insert(entity);
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}