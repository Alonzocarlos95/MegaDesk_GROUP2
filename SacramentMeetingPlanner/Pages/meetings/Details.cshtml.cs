using System;
using System.Collections.Generic;
using System.Linq;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;


namespace SacramentMeetingPlanner.Pages.meetings
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public DetailsModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.ID == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPostCreateDocument()
        {
            //Create a new PDF document
            PdfDocument document = new PdfDocument();

            //Add a page to the document
            PdfPage page = document.Pages.Add();

            //Create PDF graphics for the page
            _ = page.Graphics;

            //Set the standard font
            _ = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

            //Saving the PDF to the MemoryStream
            MemoryStream stream = new MemoryStream();
            document.Save(stream);

            //PDF will be empty if position is not set to '0'.
            stream.Position = 0;

            //Download the PDF file.
            FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf")
            {
                FileDownloadName = "Meeting Agenda.pdf"
            };
            return fileStreamResult;
        }
    }
}
