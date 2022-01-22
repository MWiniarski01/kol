using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Kolokwium.Model.DataModels
{
    public class Department
    {
        // public int Id { get; set; }
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public virtual Person Dean { get; set; }

        public virtual IList<Student> Students { get; set; }

        public int IndexNumber { get; set; }
    }
}
