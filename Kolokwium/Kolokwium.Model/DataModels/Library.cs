using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Kolokwium.Model.DataModels
{
    public class Library
    {
        // public int LibraryId { get; set; }
        public string Address { get; set; }

        public virtual IList<Book> Books { get; set; }

        public virtual IList<Client> Clients { get; set; }

        public virtual IList<Employee> Employees { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
