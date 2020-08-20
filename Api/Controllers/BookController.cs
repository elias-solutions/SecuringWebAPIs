namespace Api.Controllers
{
    using System;
    using System.Linq;
    using Api.Models;
    using Api.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("/api/v1/books")]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<Book[]> Get()
        {
            var items = _bookService.Get();
            return Ok(items.ToArray());
        }

        [HttpPost]
        public ActionResult<Book> Add([FromBody] Book item)
        {
            var addedBook = _bookService.Add(item);
            return Ok(addedBook);
        }

        [HttpPut]
        public ActionResult<Book> Update([FromBody] Book item)
        {
            var updatedItem = _bookService.Update(item);
            return Ok(updatedItem);
        }

        [HttpDelete("{identifier}")]
        [Authorize]
        public ActionResult<Guid> Delete(Guid identifier)
        {
            var deletedIdentifier = _bookService.Delete(identifier);
            return Ok(deletedIdentifier);
        }
    }
}