﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
