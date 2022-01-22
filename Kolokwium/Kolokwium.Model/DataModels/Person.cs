using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int Age { get; }
    }
}
// https://github.com/department-intelligent-computer-systems/Zaawansowane_Programowanie_Internetowe_N
// dotnet ef migrations add Initial --project .\Kolokwium.DAL\Kolokwium.DAL.csproj --startup-project .\Kolokwium.Web\Kolokwium.Web.csproj
// dotnet ef database update --project .\Kolokwium.DAL\Kolokwium.DAL.csproj --startup-project .\Kolokwium.Web\Kolokwium.Web.csproj
