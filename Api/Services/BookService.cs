namespace Api.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Api.Models;

    public class BookService
    {
        private List<Book> _data;

        public BookService()
        {
            _data = CreateData().ToList();
        }

        public IEnumerable<Book> Get()
        {
            return _data;
        }

        public Book Add(Book newItem)
        {
            var item = new Book { Title = newItem.Title, Author = newItem.Author};
            _data.Add(item);
            return item;
        }

        public Book Update(Book updateItem)
        {
            var item = _data.Find(x => x.Identifier.Equals(updateItem.Identifier));
            item.Author = updateItem.Author;
            item.Title = updateItem.Title;
            return item;
        }

        public Guid Delete(Guid identifier)
        {
            var item = _data.Find(book => book.Identifier.Equals(identifier));
            _data.Remove(item);
            return item.Identifier;
        }


        private IEnumerable<Book> CreateData()
        {
            yield return new Book {Identifier = Guid.NewGuid(), Title = "Lord of the Rings", Author = "J. R. R. Tolkien"};
            yield return new Book {Identifier = Guid.NewGuid(), Title = "Das Parfüm", Author = "Patrick Süskind"};
            yield return new Book {Identifier = Guid.NewGuid(), Title = "Die Päpstin", Author = "Donna Woolfolk Cross" };
        }
    }
}