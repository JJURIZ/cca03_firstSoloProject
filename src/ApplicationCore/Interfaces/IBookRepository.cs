using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IBookRepository
    {
        List<Book> ListAll();
        Book GetById(int Id);
        void Add(Book newBook);
        void Edit(Book editBook);
        void Delete(Book deleteBook);
    }
}
