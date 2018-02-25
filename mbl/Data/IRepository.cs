namespace mbl.Data {
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<T> {
        Task<List<T>> GetAll();

        T GetById(int Id);

        List<T> GetBy_();

        Task Add(T entity);

        void Update(T entity);
    }
}