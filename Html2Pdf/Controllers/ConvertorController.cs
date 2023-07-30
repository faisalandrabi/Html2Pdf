using Html2Pdf.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Html2Pdf.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConvertorController : ControllerBase
    {
        [HttpGet(Name = "2Pdf")]
        public IActionResult Get(String html)
        {
            if (String.IsNullOrEmpty(html))
            {
                return NotFound();
            }

            PdfConvertor pc = new PdfConvertor();
            Guid guid = Guid.NewGuid();
            
            return File(
            pc.ToPdf(html),
            "application/pdf",
            guid+".pdf"
                );
        }

    }

}