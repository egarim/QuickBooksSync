using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            CreditMemoLineItems = new HashSet<CreditMemoLineItem>();
            EstimateLineItems = new HashSet<EstimateLineItem>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Items = new HashSet<Item>();
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            StatementCharges = new HashSet<StatementCharge>();
            UnitOfMeasureDefaultUnits = new HashSet<UnitOfMeasureDefaultUnit>();
            UnitOfMeasureRelatedUnits = new HashSet<UnitOfMeasureRelatedUnit>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? UnitOfMeasureType { get; set; }
        public string? BaseUnitName { get; set; }
        public string? BaseUnitAbbreviation { get; set; }
        public string? RelatedUnitAggregate { get; set; }
        public string? DefaultUnitAggregate { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItems { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItems { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<StatementCharge> StatementCharges { get; set; }
        public virtual ICollection<UnitOfMeasureDefaultUnit> UnitOfMeasureDefaultUnits { get; set; }
        public virtual ICollection<UnitOfMeasureRelatedUnit> UnitOfMeasureRelatedUnits { get; set; }
    }
}
