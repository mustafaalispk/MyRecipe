﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Models.Domain
{
    public enum RecipeState
    {
        Draft,
        PendingApproval,
        Approved,
        Rejected
    }
}
