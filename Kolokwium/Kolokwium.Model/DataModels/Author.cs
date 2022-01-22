using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Kolokwium.Model.DataModels
{
    public class Author : Person
    {
        public int AuthorId { get; set; }

        public virtual IList<Book> BookList { get; set; }

        public virtual IList<BookAuthor> BookAuthors { get; set; }
    }
}
