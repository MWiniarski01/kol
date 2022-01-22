using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Kolokwium.Model.DataModels
{
    public class Book
    {
        public int BookId { get; set; }

        public int LibraryId { get; set; }

        public virtual Library Library { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Person Dean { get; set; }

        public virtual IList<Student> Students { get; set; }

        public virtual IList<BookAuthor> BookAuthors { get; set; }

        public int IndexNumber { get; set; }

        public virtual Client Client { get; set; }

        public int BorrowedBooksId { get; set; }
    }
}
