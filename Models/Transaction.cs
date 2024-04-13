using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BankTransactions.Models
{
    public class Transaction
    {
        public int id { get; set; }
        [DisplayName("Account Number")]
        [Required]
        public string AccountNumber { get; set; }
        [DisplayName("Beneficiary Name")]
        [Required]
        public string BeneficiaryName { get; set; }
        [DisplayName("Bank Name")]
        [Required]
        public string BankName { get; set; }
        [DisplayName("SWIFT Code")]
        [Required]
        public string SWIFTCode { get; set; }
        [DisplayName("Amount")]
        [Required]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }=DateTime.Now;    
    }
}
