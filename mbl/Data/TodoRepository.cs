namespace mbl.Data {
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using mbl.Domains;

    public class TodoRepository: RepositoryBase<TodoModel>, IRepository<TodoModel> {
        public TodoRepository(string databaseName, string collectionName)
            : base(databaseName, collectionName) {
        }
    }
}