using CMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class CMSContext : DbContext
    {
        public CMSContext(DbContextOptions options) : base(options)
        {
        }


        /// <summary>
        /// Bahria Bill Bank Data
        /// </summary>
        public DbSet<GetBillingData>getbillingdata{ get; set; }
        public DbSet<GetBillingDate> getbillingdate { get; set; }
        public DbSet<LoginData>getLogindata{ get; set; }



        /// <summary>
        /// Bahria Bill Website Data
        /// </summary>



        public DbSet<bahriabilling> bahriabilling { get; set; }
        public DbSet<bahriabillingment> bahriabillingment { get; set; }

        public DbSet<BillingDataModel> billingdatamodel { get; set; }
        public DbSet<GetallBillingData> getallbillingdata { get; set; }





    }
}
