﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimAplikacija_V2._0.DataAccess
{
    public class PaymentDate
    {
        public int Id { get; set; }
        public Payment Payment { get; set; }
        public InstallenmentDate InstallenmentDate { get; set; }
        public InstallenmentAmount InstallenmentAmount { get; set; }
    }
}
