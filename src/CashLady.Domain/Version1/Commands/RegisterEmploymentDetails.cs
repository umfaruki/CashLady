﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashLady.CqrsLib;

namespace CashLady.Domain.Version1.Commands
{
    public class RegisterEmploymentDetails : Command
    {
        public Guid UserId { get; set; }

        public decimal NetSalary { get; set; }

        public string NationalInsuranceNumber { get; set; }

        public string CurrentEmployment { get; set; }

        public string CurrentPosition { get; set; }

        public int YearsWithCurrentEmployer { get; set; }
    }
}
