namespace CMS.Models
{
    public class UpdatePaymentStatusModel
    {
        public string ReferenceNo { get; set; }
        public string? CompanyCode { get; set; }

        public string Status { get; set; }
       
        public string received_date { get; set; }
       // public string Inquiry_date { get; set; }
        public string Amount{ get; set;}


        public string UserID { get; set; }

        public string Password { get; set; }
      
    }
}
