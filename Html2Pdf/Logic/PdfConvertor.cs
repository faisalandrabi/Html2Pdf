
using SelectPdf;
using System.Drawing;

namespace Html2Pdf.Logic
{
    public class PdfConvertor
    {
        public byte[] ToPdf(String html)
        {
            html = html.Replace("StrTag", "<").Replace("EndTag", ">");
            HtmlToPdf h2p = new HtmlToPdf();
            h2p.Options.EmbedFonts = true;
            
            PdfDocument pdfDoc = h2p.ConvertHtmlString(html);
            PdfFont pf = pdfDoc.AddFont(new System.Drawing.Font("Verdana",15));
            byte[] pdf = pdfDoc.Save();
            pdfDoc.Close();
            return pdf;
        }

    }
}
