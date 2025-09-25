using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class bahriabilling
    {
        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }

        [Column("Online PMNT Refrence")]
        public string? OnlinePMNTRefrence { get; set; }

        [Key]
        [Column("NewRefrence")]
        public double? NewRefrence { get; set; }

        [Column("UD")]
        public double? UD { get; set; }

        [Column("OldRefrence")]
        public string? OldRefrence { get; set; }

        [Column("ReadingDate")]
        public DateTime? ReadingDate { get; set; }

        [Column("IssueDate")]
        public DateTime? IssueDate { get; set; }

        [Column("DateDue")]
        public DateTime? DateDue { get; set; }

        [Column("CONN#DATE")]
        public DateTime? CONN_DATE { get; set; }

        [Column("BillingMonth")]
        public string? BillingMonth { get; set; }

        [Column("BilllingYear")]
        public double? BillingYear { get; set; }

        [Column("Jan-Year")]
        public double? JanYear { get; set; }

        [Column("Jan-Units")]
        public double? JanUnits { get; set; }

        [Column("Jan")]
        public double? Jan { get; set; }

        [Column("Jan-Status")]
        public double? JanStatus { get; set; }

        [Column("Feb-Year")]
        public double? FebYear { get; set; }

        [Column("Feb-Units")]
        public double? FebUnits { get; set; }

        [Column("Feb")]
        public double? Feb { get; set; }

        [Column("Feb-Status")]
        public double? FebStatus { get; set; }

        [Column("Mar-Year")]
        public double? MarYear { get; set; }

        [Column("Mar-Units")]
        public double? MarUnits { get; set; }

        [Column("Mar")]
        public double? Mar { get; set; }

        [Column("Mar-Status")]
        public double? MarStatus { get; set; }


        [Column("april-year")]
        public double? aprilyear { get; set; }

        [Column("April")]
        public double? April { get; set; }
        
        [Column("april-units")]
        public double? aprilunits { get; set; }
        [Column("april-status")]
        public double? aprilstatus { get; set; }



        [Column("May-Year")]
        public double? MayYear { get; set; }

        [Column("May-Units")]
        public double? MayUnits { get; set; }

        [Column("May")]
        public double? May { get; set; }

        [Column("May-Status")]
        public double? MayStatus { get; set; }

        [Column("June-Year")]
        public double? JuneYear { get; set; }

        [Column("June-Units")]
        public double? JuneUnits { get; set; }

        [Column("June")]
        public double? June { get; set; }

        [Column("jane-status")]
        public double? JuneStatus { get; set; }

        [Column("July-Year")]
        public double? JulyYear { get; set; }

        [Column("July-Units")]
        public double? JulyUnits { get; set; }

        [Column("July")]
        public double? July { get; set; }

        [Column("July-Status")]
        public double? JulyStatus { get; set; }

        [Column("aug-year")]
        public double? AugYear { get; set; }

        [Column("aug-units")]
        public double? AugUnits { get; set; }

        [Column("Aug")]
        public double? Aug { get; set; }

        [Column("aug-status")]
        public double? AugStatus { get; set; }

        [Column("Sep-Year")]
        public double? SepYear { get; set; }

        [Column("Sep-Units")]
        public double? SepUnits { get; set; }

        [Column("Sep")]
        public double? Sep { get; set; }

        [Column("Sep-Status")]
        public double? SepStatus { get; set; }

        [Column("Oct-Year")]
        public double? OctYear { get; set; }

        [Column("Oct-Units")]
        public double? OctUnits { get; set; }

        [Column("Oct")]
        public double? Oct { get; set; }

        [Column("Oct-Status")]
        public double? OctStatus { get; set; }

        [Column("Nov-Year")]
        public double? NovYear { get; set; }

        [Column("Nov-Units")]
        public double? NovUnits { get; set; }

        [Column("Nov")]
        public double? Nov { get; set; }

        [Column("Nov-Status")]
        public double? NovStatus { get; set; }

        [Column("Dec-Year")]
        public double? DecYear { get; set; }

        [Column("dec-units")]
        public double? DecUnits { get; set; }

        [Column("Dec")]
        public double? Dec { get; set; }

        [Column("dec-status")]
        public double? DecStatus { get; set; }

        [Column("Tarrif")]
        public string? Tarrif { get; set; }

        [Column("Load")]
        public string? Load { get; set; }

        [Column("Meter_Type")]
        public string? Meter_Type { get; set; }

        [Column("Customer-Name")]
        public string? Customer_Name { get; set; }

        [Column("Plot-Number")]
        public string? Plot_Number { get; set; }

        [Column("Street-Number")]
        public string? Street_Number { get; set; }

        [Column("Sector")]
        public string? Sector { get; set; }

        [Column("Meter No")]
        public double? MeterNo { get; set; }

        [Column("Previous")]
        public double? Previous { get; set; }

        [Column("Present")]
        public double? Present { get; set; }

        [Column("MF")]
        public double? MF { get; set; }

        [Column("Total Unit")]
        public double? TotalUnit { get; set; }

        [Column("PreviousPeak")]
        public double? PreviousPeak { get; set; }

        [Column("PreviousOffPeak")]
        public double? PreviousOffPeak { get; set; }

        [Column("PresentPeak")]
        public double? PresentPeak { get; set; }

        [Column("PresentOffPeak")]
        public double? PresentOffPeak { get; set; }

        [Column("PeakTotal")]
        public double? PeakTotal { get; set; }

        [Column("OffPeakTotal")]
        public double? OffPeakTotal { get; set; }

        [Column("Status")]
        public string? Status { get; set; }

        [Column("COE")]
        public double? COE { get; set; }

        [Column("NJ")]
        public double? NJ { get; set; }

        [Column("Advance")]
        public double? Advance { get; set; }

        [Column("IncomeTax")]
        public double? IncomeTax { get; set; }

        [Column("ED")]
        public double? ED { get; set; }

        [Column("TRSurcharge")]
        public double? TRSurcharge { get; set; }

        [Column("BillAdjustment")]
        public double? BillAdjustment { get; set; }

        [Column("ExtraTax")]
        public string? ExtraTax { get; set; }

        [Column("FPA")]
        public double? FPA { get; set; }

        [Column("Current Bill")]
        public double? CurrentBill { get; set; }

        [Column("Arrears")]
        public double? Arrears { get; set; }

        [Column("PTV Fees")]
        public double? PTVFees { get; set; }

        [Column("GST")]
        public double? GST { get; set; }

        [Column("Furthur Tax")]
        public double? FurthurTax { get; set; }

        [Column("AdvanceTax")]
        public double? AdvanceTax { get; set; }

        [Column("FCSurcharge")]
        public double? FCSurcharge { get; set; }

        [Column("Feeder")]
        public double? Feeder { get; set; }

        [Column("UnitsRate1")]
        public double? UnitsRate1 { get; set; }

        [Column("UnitSubsidy1")]
        public double? UnitSubsidy1 { get; set; }

        [Column("AppliedUnitRate1")]
        public double? AppliedUnitRate1 { get; set; }

        [Column("AppliedUnit1")]
        public double? AppliedUnit1 { get; set; }

        [Column("UnitsRate2")]
        public double? UnitsRate2 { get; set; }

        [Column("UnitSubsidy2")]
        public double? UnitSubsidy2 { get; set; }

        [Column("AppliedUnitRate2")]
        public double? AppliedUnitRate2 { get; set; }

        [Column("AppliedUnit2")]
        public double? AppliedUnit2 { get; set; }

        [Column("Amount Due dATE")]
        public double? AmountDueDate { get; set; }

        [Column("Surcharges")]
        public double? Surcharges { get; set; }

        [Column("AmountAfterDate")]
        public double? AmountAfterDate { get; set; }

        [Column("Phase")]
        public string? Phase { get; set; }

        [Column("PreviousPeakSolar")]
        public double? PreviousPeakSolar { get; set; }

        [Column("PreviousOffPeakSolar")]
        public double? PreviousOffPeakSolar { get; set; }

        //[Column("PreviousSolar")]
        //public double? PreviousSolar { get; set; }

        [Column("CurrentPeakSolar")]
        public double? CurrentPeakSolar { get; set; }

        [Column("CurrentOffPeakSolar")]
        public double? CurrentOffPeakSolar { get; set; }

        [Column("CurrentExport")]
        public double? CurrentExport { get; set; }
        public double? qtr { get; set; }

        public double? tarrifadj { get; set; }
       //public double? PreviousExport { get; set; }

    }
}
