using System.Transactions;

namespace BankTransactions.ViewModels
{
    public class TransactionAddOrEditViewModel
    {
        Transaction transaction { get; set; }
        public string PageTitle { get; set; }
    }
}
