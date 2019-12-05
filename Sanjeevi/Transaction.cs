using System;
using System.Collections.Generic;
using System.Text;

namespace Sanjeevi
{
    public class Transaction
    {
        private string _from { get; set; }
        private string _to { get; set; }
        private double _amount { get; set; }
        
        public Transaction(string from, string to, double amount)
        {
            _from = from;
            _to = to;
            _amount = amount;
        }

        public string From { get { return _from; } }
        public string To { get { return _to; } }
        public double Amount { get { return _amount; } }
    }
}
