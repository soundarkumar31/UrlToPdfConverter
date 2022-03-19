using System;
using SelectPdf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdf1
{
    internal static class Helper
    {
        public static void ConvertPdfFile()
        {
            try
            {
                string fileName = @"C:\AUD Projects\Test2.pdf"; // change your file path
                HtmlToPdf converter = new HtmlToPdf();
                PdfDocument doc = converter.ConvertUrl("https://en.wikipedia.org/wiki/Portable_Document_Format");                
                doc.Save(fileName);
                doc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
