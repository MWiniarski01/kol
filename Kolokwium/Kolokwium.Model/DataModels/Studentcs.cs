using System;
using Microsoft.AspNetCore.Identity;

// namespace Kolokwium.Model
namespace Kolokwium.Model.DataModels
{
    public class Student : Person
    {
        // public int Id { get; set; }
        public int IndexNumber { get; set; }

        public virtual Book Book { get; set; }

        public int StudentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
