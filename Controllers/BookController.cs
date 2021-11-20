using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OnlineLibrary.Areas.Identity.Data;
using OnlineLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Controllers
{
    public class BookController : Controller
    {
        private IHostingEnvironment _environment;

        private readonly BookContext _context;

        public BookController(IHostingEnvironment environment, BookContext context)
        {
            _environment = environment;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateBook()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateBook(Book model)
        {
            var imgurl = UploadedFile(model);
            var book = new Book();
            book.Authors = model.Authors;
            book.Title = model.Title;
            book.Publisher = model.Publisher;
            book.ISBN = model.ISBN;
            book.Publishdate = model.Publishdate;
            book.BookGenre = model.BookGenre;
            book.DateAdded = model.DateAdded;
            book.RevisionNumber = model.RevisionNumber;
            book.BookImageUrl = imgurl;
            book.DateAdded = DateTime.Now.ToString();
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("ListBooks");
        }

        public IActionResult ListBooks()
        {
            var allbooks = _context.Books.ToList();
            return View(allbooks);
        }

        [HttpPost]
        public IActionResult EditBook(Book model)
        {
            
            var imgurl = UploadedFile(model);
            var book =_context.Books.Where(x=>x.Id==model.Id).FirstOrDefault();
            book.Authors = model.Authors;
            book.Title = model.Title;
            book.Publisher = model.Publisher;
            book.ISBN = model.ISBN;
            book.Publishdate = model.Publishdate;
            book.BookGenre = model.BookGenre;
            book.DateAdded = model.DateAdded;
            book.RevisionNumber = model.RevisionNumber;
            book.BookImageUrl = imgurl;
            book.DateAdded = DateTime.Now.ToString();
            
            _context.SaveChanges();
            return RedirectToAction("ListBooks");
        }

        public IActionResult EditBook(int id)
        {
            var mdel = _context.Books.Where(x => x.Id == id).FirstOrDefault();
            return View(mdel);
        }

        private string UploadedFile(Book model)
        {
            string uniqueFileName = null;
            var tt = 0;
            if (model.BookImage != null)
            {

                string uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.BookImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.BookImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public IActionResult CheckOutBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOutBook(Book model)
        {
            var mdel = new BookCheckinCheckout();
            mdel.CheckOutdate = DateTime.Now.ToString();
            mdel.CheckStatus = 1;
            mdel.CheckOutStatus = 1;
            mdel.readerId = User.Identity.Name;
            mdel.CheckInStatus = 0;
            mdel.CheckInDate = "";
            mdel.BookId = model.Id;

            return View();
        }

        //list of book books that has been checked out
        public IActionResult ListCkeckOutBooks()
        {
            var allcc = _context.BookCheckinCheckouts.ToList();
            return View(allcc);
        }

        //search box to find books
        public IActionResult SearchForBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchForBook(string searchbox,string searchString)
        {
            return View();
        }
    }
}
