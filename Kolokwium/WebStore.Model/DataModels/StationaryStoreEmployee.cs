using System;
using System.Collections.Generic;

namespace WebStore.Model.DataModels
{
    public class StationaryStoreEmployee : User
    {
        public int StationaryStoreEmployeeId { get; set; }
        public int StationaryStoreId { get; set;}
        public virtual StationaryStore StationaryStore { get; set; }
        public virtual Address EmployeeAddress { get; set; }
    }
}