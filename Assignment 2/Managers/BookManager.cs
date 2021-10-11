using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1;

namespace Assignment_2.Managers
{
    public class BookManager
    {
        private static List<Book> _Books = new List<Book>() {
            new Book ("c# programming","Tom",200,"978-3-16-148410-0"),
            new Book ("Java","Zia",300,"977-3-16-158410-0"),
            new Book ("c++","khan",400,"976-3-16-168410-0")
            };
            
        public List<Book> GetAll()
        {
            return new List<Book>(_Books);


        }

        public Book Get(String ISBN13)
        {
            return _Books.Find(book => book.ISBN13 == ISBN13);
        }

        public Book create(Book book)
        {
            var _book = _Books.Find(boook => boook.ISBN13 == book.ISBN13);
            if (_book == null)
            {

                _Books.Add(book);

                return book;
            }
            return null;
        }
        public Book Update(String ISBN13,Book book)
        {
          var _book=  _Books.Find(book => book.ISBN13 == ISBN13);
            _book.Author = book.Author;
            _book.Title = book.Title;
            _book.PageNumber = book.PageNumber;
            return _book;



        }
        public Book Delete(String ISBN13)
        {
            var _book = _Books.Find(book => book.ISBN13 == ISBN13);
            _Books.Remove(_book);
            return _book;
        }
        

        }
    }

