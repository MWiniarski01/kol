using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Kolokwium.Model.DataModels
{
    public class Client : Person
    {
        public int ClientId { get; set; }

        public virtual Library Library { get; set; }

        public virtual IList<Book> BorrowedBooks { get; set; }
    }
}
