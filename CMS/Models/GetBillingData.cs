
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class GetBillingData
    {
        [Key]
        public string ReferenceNo { get; set; }
        [Column("BillingMonth")]
        public string? BillingMonth { get; set; }
        [Column("CompanyCode")]
        public string? CompanyCode { get; set; }
        public string? CustomerName { get; set; }
        [Column("BillingYear")]
        public string? BillingYear { get; set; }
        [Column("ReadingDate")]
        public string? ReadingDate { get; set; }

        [Column("IssueDate")]
        public string? IssueDate { get; set; }

        [Column("DueDate")]
        public string? DueDate { get; set; }

        [Column("AmountDueDate")]
        public string? AmountDueDate { get; set; }
        [Column("AmountAfterDate")]
        public string? AmountAfterDate { get; set; }
        public string? Status { get; set; }


        //public string Recevied_date { get; set; }
        //public string Inquiry_date { get; set; }
        //public string Amount { get; set; }

        // public int? PaymentModule { get; set; }


        //public DateTime? DueDate { get; set; }



    }
    public class GetBillingDate
    {
        [Key]
        public DateTime Expiredate { get; set; }
    }
}
