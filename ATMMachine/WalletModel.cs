﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    public class WalletModel
    {
        public double Balance { get; set; }
        public WalletModel(double balance)
        {
            Balance = balance;
        }
    }
}
