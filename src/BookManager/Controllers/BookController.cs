using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepo;

        public BookController(IBookRepository bRepo)
        {
            _bookRepo = bRepo;
        }

        // GET: Book
        public ActionResult Index()
        {
            return View(_bookRepo.ListAll());
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View(_bookRepo.GetById(id));
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book newBook)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _bookRepo.Add(newBook);
                }

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                // TODO Log the Error
                //return View(newBook);
            }
            return View(newBook);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_bookRepo.GetById(id));
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book editedBook)
        {
            try
            {
                _bookRepo.Edit(editedBook);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
               // TODO Log the exception 
            }
            return View(editedBook);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book bookToDelete)
        {
            try
            {
                _bookRepo.Delete(bookToDelete);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                // TODO Log the Exception
            }
            return View(bookToDelete);

        }
    }
}