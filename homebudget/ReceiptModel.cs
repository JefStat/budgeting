using System;
using System.Collections.Generic;

namespace homebudget
{
    public class ReceiptModel
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public double OriginalAmount { get; set; }
        public List<double> Amounts { get; set; }
        public List<string> Memos { get; set; }
        public ReceiptModel Link { get; set; }
        public List<string> Images { get; set; }
    }
}
