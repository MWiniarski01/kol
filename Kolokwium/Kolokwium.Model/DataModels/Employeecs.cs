using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Kolokwium.Model.DataModels
{
    public class Employee : Person
    {
        public virtual Library Library { get; set; }

        public int LibraryId { get; set; }

        public int EmployeeId { get; set; }
    }
}
