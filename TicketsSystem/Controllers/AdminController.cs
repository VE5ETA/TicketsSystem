using FileUploadControl;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketsSystem.Data;
using TicketsSystem.Models;
using TicketsSystem.Models.ViewModels;

namespace TicketsSystem.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private UploadInterface _upload;
        public AdminController(ApplicationDbContext context, UploadInterface upload)
        {
            _upload= upload;
            _context= context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IList<IFormFile> files, TicketViewmodel vmodel, Ticket ticket)
        {

            ticket.Title = vmodel.Title;
            ticket.Description = vmodel.Description;
            ticket.Location = vmodel.Location;
            ticket.DateAndTime = vmodel.DateAndTime;

            foreach (var item in files) {
                ticket.Logo = "~/uploads/" + item.FileName.Trim();
            }

            _upload.uploadfilemultiple(files);
            _context.Ticket.Add(ticket);
             _context.SaveChanges();
            TempData["Sucess"] = "Save Your Ticket";
            return RedirectToAction("Create","Admin");
        }
    }
}
