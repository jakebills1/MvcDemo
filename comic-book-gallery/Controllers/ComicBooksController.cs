using comic_book_gallery.Data;
using Microsoft.AspNetCore.Mvc;



namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
        }
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }
    }
    
}

