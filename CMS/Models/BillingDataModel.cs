using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class BillingDataModel
    {
        public double Advance { get; set; }
        public double AdvanceTax { get; set; }
        [Column("Amount Due dATE")]
        public double AmountDueDate { get; set; }
        public double AmountAfterDate { get; set; }
        public double AppliedUnit1 { get; set; }
        public double AppliedUnit2 { get; set; }
        public double AppliedUnitRate1 { get; set; }
        public double AppliedUnitRate2 { get; set; }
        public double April { get; set; }
        [Column("april-status")]
        public double AprilStatus { get; set; }
        public double AprilUnits { get; set; }
        public double AprilYear { get; set; }
        public double Arrears { get; set; }
        public double Aug { get; set; }
        public double AugStatus { get; set; }
        public double AugUnits { get; set; }
        public double AugYear { get; set; }
        public double BillAdjustment { get; set; }
        public string BillingMonth { get; set; }
        public double BilllingYear { get; set; }
        public double COE { get; set; }
        public DateTime CONN_DATE { get; set; }
        public DateTime CreationDate { get; set; }
        public double CurrentBill { get; set; }
        public double CurrentExport { get; set; }
        public double CurrentOffPeakSolar { get; set; }
        public double CurrentPeakSolar { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateDue { get; set; }
        public double Dec { get; set; }
        public double DecStatus { get; set; }
        public double DecUnits { get; set; }
        public double DecYear { get; set; }
        public double ED { get; set; }
        public double ExtraTax { get; set; }
        public double FCSurcharge { get; set; }
        public double Feb { get; set; }
        public double FebStatus { get; set; }
        public double FebUnits { get; set; }
        public double FebYear { get; set; }
        public double Feeder { get; set; }
        public double FPA { get; set; }
        public string FurthurTax { get; set; }
        public double GST { get; set; }
        public double Incometax { get; set; }
        public DateTime Issuedate { get; set; }
        public double Jan { get; set; }
        public double JanStatus { get; set; }
        public double JanUnits { get; set; }
        public double JanYear { get; set; }
        public double JaneStatus { get; set; }
        public double July { get; set; }
        public double JulyStatus { get; set; }
        public double JulyUnits { get; set; }
        public double JulyYear { get; set; }
        public double June { get; set; }
        public double JuneUnits { get; set; }
        public double JuneYear { get; set; }
        public string Load { get; set; }
        public double Mar { get; set; }
        public double MarStatus { get; set; }
        public double MarUnits { get; set; }
        public double MarYear { get; set; }
        public double May { get; set; }
        public double MayStatus { get; set; }
        public double MayUnits { get; set; }
        public double MayYear { get; set; }
        public double MeterNo { get; set; }
        public string MeterType { get; set; }
        public double MF { get; set; }
        [Key]
        public double NewRefrence { get; set; }
        public double NJ { get; set; }
        public double Nov { get; set; }
        public double NovStatus { get; set; }
        public double NovUnits { get; set; }
        public double NovYear { get; set; }
        public double Oct { get; set; }
        public double OctStatus { get; set; }
        public double OctUnits { get; set; }
        public double OctYear { get; set; }
        public double OffPeakTotal { get; set; }
        public string OldRefrence { get; set; }
        public double OnlinePaymentRefrence { get; set; }
        public double PeakTotal { get; set; }
        public string Phase { get; set; }
        public double PlotNumber { get; set; }
        public double Present { get; set; }
        public double PresentOffPeak { get; set; }
        public double PresentPeak { get; set; }
        public double Previous { get; set; }
        public double PreviousExport { get; set; }
        public double PreviousOffPeak { get; set; }
        public double PreviousOffPeakSolar { get; set; }
        public double PreviousPeak { get; set; }
        public double PreviousPeakSolar { get; set; }
        public double PTVFees { get; set; }
        public DateTime ReadingDate { get; set; }
        public string Sector { get; set; }
        public double Sep { get; set; }
        public double SepStatus { get; set; }
        public double SepUnits { get; set; }
        public double SepYear { get; set; }
        public string Status { get; set; }
        public double StreetNumber { get; set; }
        public double Surcharges { get; set; }
        public string Tarrif { get; set; }
        public double TotalUnit { get; set; }
        public double TRSurcharge { get; set; }
        public double UD { get; set; }
        public double UnitsRate1 { get; set; }
        public double UnitsRate2 { get; set; }
        public double UnitsSubsidy1 { get; set; }
        public double UnitsSubsidy2 { get; set; }
    }
}
