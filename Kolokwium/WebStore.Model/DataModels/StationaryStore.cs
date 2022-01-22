using System;
using System.Collections.Generic;

namespace WebStore.Model.DataModels
{
    public class StationaryStore
    {
        public int StationaryStoreId { get; set; }
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<StationaryStoreEmployee> StationaryStoreEmployees { get; set; }
    }
}