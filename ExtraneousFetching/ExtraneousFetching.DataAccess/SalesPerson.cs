﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace ExtraneousFetching.DataAccess
{
    public class SalesPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        public int? TerritoryId { get; set; } // TerritoryID

        public decimal? SalesQuota { get; set; } // SalesQuota

        public decimal Bonus { get; set; } // Bonus

        public decimal CommissionPct { get; set; } // CommissionPct

        public decimal SalesYtd { get; set; } // SalesYTD

        public decimal SalesLastYear { get; set; } // SalesLastYear

        public Guid Rowguid { get; set; } // rowguid

        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesPerson_SalesPersonID

        public SalesPerson()
        {
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }
}