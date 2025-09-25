using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class GetallBillingData
    {
        [Key]
        [Column("NewRefrence")]
        public double? NewRefrence { get; set; }
        [Column("BillingMonth")]
        public string? BillingMonth { get; set; }
        [Column("BilllingYear")]
        public double? BillingYear { get; set; }
        [Column("ReadingDate")]
        public DateTime? ReadingDate { get; set; }

        [Column("IssueDate")]
        public DateTime? IssueDate { get; set; }

        [Column("DateDue")]
        public DateTime? DateDue { get; set; }

        [Column("AmountDueDate")]
        public double? AmountDueDate { get; set; }
        [Column("AmountAfterDate")]
        public double? AmountAfterDate { get; set; }

        //public DateTime? DueDate { get; set; }

    }
}
