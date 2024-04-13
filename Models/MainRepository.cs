using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class MainRepository<T> : MainInterface<T> where T : class

    {
        private readonly TransactionDbContext context;

        public MainRepository(TransactionDbContext context)
        {
            this.context = context;
        }

          public T Add(T item)
        {
            context.Set<T>().Add(item); 
            context.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            var model = Get(id);
            context.Set<T>().Remove(model); 
            context.SaveChanges() ;
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T Update(int id, T item)
        {
            DbSet<T> ts = context.Set<T>();
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
            return item;

        }
    }
}
