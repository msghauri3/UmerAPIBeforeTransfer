    using CMS.RwpBill;
using CMS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceBillController : ControllerBase
    {
       
        
        
        
        
        [HttpGet("GetMaintenanceBillS")]
        public async Task<IActionResult> GetMaintenanceBill([
            FromQuery]  string? block, [FromQuery] string? Category,
                                                   [FromQuery] string? month, [FromQuery] string? year, [FromQuery] string? Project,
                                                   [FromServices] BillingService billingService)
        {

                var report = new MultiMaintenance();

                
                if (report == null)
                {
                    return StatusCode(500, "Failed to initialize the MaintenanceBill report.");
                }
            report.Parameters["Category"].Value = Category;
            report.Parameters["Category"].Visible = false;

            report.Parameters["Block"].Value = block;
            report.Parameters["Block"].Visible = false;

            report.Parameters["BillingMonth"].Value = month;
            report.Parameters["BillingMonth"].Visible = false;

            report.Parameters["BillingYear"].Value = year;
            report.Parameters["BillingYear"].Visible = false;


            report.Parameters["Project"].Value = Project;
            report.Parameters["Project"].Visible = false;

            using var stream = new MemoryStream();
                report.ExportToPdf(stream);
                stream.Seek(0, SeekOrigin.Begin);

                
                return File(stream.ToArray(), "application/pdf", "MaintenanceBill.pdf");
           
           
        }
    }
}
