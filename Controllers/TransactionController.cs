using BankTransactions.Models;
using BankTransactions.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BankTransactions.Controllers
{
    public class TransactionController : Controller
    {
        private readonly MainInterface<Transaction> _transaction;

        public TransactionController(MainInterface<Transaction> transaction)
        {
            _transaction = transaction;    
        }


        // GET: TransactionController
        public IActionResult Index()
        {
            return  View( _transaction.GetAll());
        }



        // GET: TransactionController/AddOrEdit
        public IActionResult AddOrEdit(int id=0)
        {
            if(id == 0)
            {
                return View();
            }
            else 
            { 
                return View(_transaction.Get(id));
            }
            
        }

        // POST: TransactionController/AddOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult AddOrEdit(Transaction transaction)
        {
          if (ModelState.IsValid)
            {
                if (transaction.id == 0)
                {
                    _transaction.Add(transaction);
                }
                else
                {
                    _transaction.Update(transaction.id, transaction);
                }
                return RedirectToAction("Index");
            }

          else
            {
                return View(transaction);
            }
                
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _transaction.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
