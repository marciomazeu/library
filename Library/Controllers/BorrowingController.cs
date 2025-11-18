using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BorrowingController : Controller
    {

        readonly private LibraryDbContext _db;

        public BorrowingController(LibraryDbContext db) {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BorrowingRecords> borrowing = _db.BorrowingRecords;
            return View(borrowing);
        }

        public IActionResult NewBorrow()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewBorrow(BorrowingRecords borrowing)
        {
            if (ModelState.IsValid)
            {
                _db.BorrowingRecords.Add(borrowing);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditBorrow(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            BorrowingRecords borrow = _db.BorrowingRecords.FirstOrDefault(x => x.Id == id);

            if (borrow == null)
            {
                return NotFound();
            }
            return View(borrow);
        }
        [HttpPost]
        public IActionResult EditBorrow(BorrowingRecords borrowing)
        {
            if (ModelState.IsValid)
            {
                _db.BorrowingRecords.Update(borrowing);
                _db.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(borrowing);
        }
        [HttpGet]
        public IActionResult DeleteBorrow(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            BorrowingRecords borrowing = _db.BorrowingRecords.FirstOrDefault(x => x.Id == id);

            if (borrowing == null)
            {
                return NotFound();
            }

            return View(borrowing);
        }
        [HttpPost]
        public IActionResult DeleteBorrow(BorrowingRecords borrowing)
        {
            if(borrowing == null)
            {
                return NotFound();
            }
            _db.BorrowingRecords.Remove(borrowing);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
