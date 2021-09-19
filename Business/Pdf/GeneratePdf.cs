using Microsoft.AspNetCore.Mvc;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Business.Pdf
{
    public class GeneratePdf : Controller
    {
        
        public async Task<IActionResult> Table(string fileName, DataTable data)
        {
            PdfDocument doc = new PdfDocument();
            //Add a page.
            PdfPage page = doc.Pages.Add();
            //Create a PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();
            //Add values to list
           // List<object> data = new List<object>();

            

            //IEnumerable<object> dataTable = data;
            ////Assign data source.
            //DataTable a = new DataTable();

            pdfGrid.DataSource = data;
            
            //Draw grid to the page of PDF document.
            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 10));
            //Save the PDF document to stream
            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            //If the position is not set to '0' then the PDF will be empty.
            stream.Position = 0;
            //Close the document.
            doc.Close(true);
            //Defining the ContentType for pdf file.
            string contentType = "application/pdf";
            //Define the file name.
          
            //Creates a FileContentResult object by using the file contents, content type, and file name.
            return File(stream, contentType, fileName);

        }
    }
}
