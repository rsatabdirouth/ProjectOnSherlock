﻿using ProjectOnSherlock.Models;
using System.Collections.Generic;

namespace ProjectOnSherlock.Models.UtilityObjects
{
    public class BuyerProductWithLeadCategory
    {
        public BuyerProduct BuyerProduct { get; set; }
        public List<EnumValueName> LeadCategories { get; set; }
        public List<EnumValueName> LeadTypes { get; set; }
    }
}
