using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ProfitAndLossDetail
    {
        public string? Label { get; set; }
        public string? Type { get; set; }
        public DateTime? Date { get; set; }
        public string? Num { get; set; }
        public string? Name { get; set; }
        public string? Memo { get; set; }
        public string? Class { get; set; }
        public string? Clr { get; set; }
        public string? Split { get; set; }
        public float? Amount { get; set; }
        public float? Balance { get; set; }
        public string? RowType { get; set; }
    }
}
