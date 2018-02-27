namespace mbl.Data {
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<T> {
        IEnumerable<T> GetAll();

        T GetById(int Id);

        IEnumerable<T> GetBy_();

        void Add(T entity);

        void Update(T entity);
    }
}