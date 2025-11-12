using System;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;




namespace itext_demo
{
    public partial class pdf_itext : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Set the response type to PDF
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=FirstPDFDocument.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            // Create a new PDF document
            Document document = new Document(iTextSharp.text.PageSize.A4, 25, 25, 30, 30);

            // Link the document to the output stream
            iTextSharp.text.pdf.PdfWriter.GetInstance(document, Response.OutputStream);

            // Open the document for writing
            document.Open();

            // Add content
            document.Add(new iTextSharp.text.Paragraph("Hello World!"));
            document.Add(new iTextSharp.text.Paragraph("This is a sample PDF created using iTextSharp in ASP.NET."));
            document.Add(new iTextSharp.text.Paragraph("Generated on: " + DateTime.Now.ToString()));

            // Close the document
            document.Close();

            // End the response
            Response.End();
        }
    }
}
