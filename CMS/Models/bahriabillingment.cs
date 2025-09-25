using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{

    public class bahriabillingment
    {
        public DateTime CreationDate { get; set; }
        [Column("Online PMNT Refrence")]
        public string? OnlinePMNTRefrence { get; set; }
        public double? GST { get; set; }
        [Key]
        [Column("NewRefrence")]
        public string? NewRefrence { get; set; }
        public double? UD { get; set; }
        public string? OldRefrence { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? DateDue { get; set; }
        public string? PlotCategory { get; set; }
        public string? Size { get; set; }
        public string? PlotStatus { get; set; }
        public string? BillingMonth { get; set; }
        public double? BillingYear { get; set; }
        [Column("Jan-Year")]
        public double? JanYear { get; set; }
        public double? janmentcharges { get; set; }
        public double? billamountjan { get; set; }
        [Column("Jan-Status")]
        public double? JanStatus { get; set; }
        [Column("Feb-Year")]
        public double? FebYear { get; set; }
        public double? febmentcharges { get; set; }
        public double? billamountfeb { get; set; }
        [Column("Feb-Status")]
        public double? FebStatus { get; set; }
        [Column("Mar-Year")]
        public double? MarYear { get; set; }
        public double? marmentcharges { get; set; }
        public double? billamountmar { get; set; }
        [Column("Mar-Status")]
        public double? MarStatus { get; set; }

        [Column("april-year")]
        public double? aprilyear { get; set; }
        public double? aprilmentcharges { get; set; }
        public double? billamountapril { get; set; }
        [Column("april-status")]
        public double? aprilstatus { get; set; }
        [Column("May-Year")]
        public double? MayYear { get; set; }
        public double? maymentcharges { get; set; }
        public double? billamountmay { get; set; }
        [Column("May-Status")]
        public double? MayStatus { get; set; }
        [Column("June-Year")]
        public double? JuneYear { get; set; }
        public double? junementcharges { get; set; }
        public double? billamountjune { get; set; }
        [Column("june-status")]
        public double? JuneStatus { get; set; }
        [Column("July-Year")]
        public double? JulyYear { get; set; }

        public double? julymentcharges { get; set; }
        public double? billamountjuly { get; set; }
        [Column("July-Status")]
        public double? JulyStatus { get; set; }
        [Column("aug-year")]
        public double? AugYear { get; set; }
        public double? augmentcharges { get; set; }
        public double? billamountaug { get; set; }
        [Column("aug-status")]
        public double? AugStatus { get; set; }
        [Column("Sep-Year")]
        public double? SepYear { get; set; }
        public double? sepmentcharges { get; set; }
        public double? billamountsep { get; set; }
        [Column("Sep-Status")]
        public double? SepStatus { get; set; }
        [Column("Oct-Year")]
        public double? OctYear { get; set; }
        public double? octmentcharges { get; set; }
        public double? billamountoct { get; set; }
        [Column("Oct-Status")]
        public double? OctStatus { get; set; }
        [Column("Nov-Year")]
        public double? NovYear { get; set; }
        public double? novmentcharges { get; set; }
        public double? billamountnov { get; set; }
        [Column("Nov-Status")]
        public double? NovStatus { get; set; }
        [Column("Dec-Year")]
        public double? DecYear { get; set; }
        public double? decmentcharges { get; set; }
        public double billamountdec { get; set; }
        [Column("dec-status")]
        public double? DecStatus { get; set; }
        [Column("Customer-Name")]
        public string? Customer_Name { get; set; }
        [Column("Plot-Number")]
        public string? Plot_Number { get; set; }

        [Column("Street-Number")]
        public double? Street_Number { get; set; }

        [Column("Sector")]
        public string? Sector { get; set; }

        [Column("meter#")]
        public double? MeterNo { get; set; }
        public double? watercharges { get; set; }
        public double? mentcharges { get; set; }
        public double? othercharges { get; set; }
        public double? foodsafety { get; set; }
        public double? insurance { get; set; }
        public double? advance { get; set; }
        public string? adleft { get; set; }
        public double? adjustment { get; set; }
        public double? arrears { get; set; }
        [Column("Amount Due dATE")]
        public double? AmountDueDate { get; set; }
        public double? Surcharges { get; set; }
        public double? AmountAfterDate { get; set; }
        public string? Phase { get; set; }
        public double? misccharges { get; set; }
        //public double? dieselcost { get; set; }
    }
}
    
    



