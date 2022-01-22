using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Kolokwium.Model.DataModels
// namespace Kolokwium.Model
{
    public class Person : IdentityUser<int>
    {
        // [Key]
        // public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        // wyliczalna wartość, bez set i z NotMapped
        [NotMapped]

        public int Age { get; }
    }
}
// https://github.com/department-intelligent-computer-systems/Zaawansowane_Programowanie_Internetowe_N
// dotnet ef migrations add Initial --project .\Kolokwium.DAL\Kolokwium.DAL.csproj --startup-project .\Kolokwium.Web\Kolokwium.Web.csproj
// dotnet ef database update --project .\Kolokwium.DAL\Kolokwium.DAL.csproj --startup-project .\Kolokwium.Web\Kolokwium.Web.csproj
