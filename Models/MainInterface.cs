namespace BankTransactions.Models
{
    public interface MainInterface<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T item);  
        T Update(int id, T item);   
        void Delete(int id);   
    }
}
