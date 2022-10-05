using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CreditCardRefund
    {
        public string Id { get; set; } = null!;
        public DateTime? TxnDate { get; set; }
        public int? TxnNumber { get; set; }
        public string? RefNumber { get; set; }
        public string? CustomerRefListId { get; set; }
        public string? CustomerRefFullName { get; set; }
        public string? RefundFromAccountRefListId { get; set; }
        public string? RefundFromAccountRefFullName { get; set; }
        public string? AraccountRefListId { get; set; }
        public string? AraccountRefFullName { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalAmountInHomeCurrency { get; set; }
        public string? AddressAddr1 { get; set; }
        public string? AddressAddr2 { get; set; }
        public string? AddressAddr3 { get; set; }
        public string? AddressAddr4 { get; set; }
        public string? AddressAddr5 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressState { get; set; }
        public string? AddressPostalCode { get; set; }
        public string? AddressCountry { get; set; }
        public string? AddressNote { get; set; }
        public string? PaymentMethodRefListId { get; set; }
        public string? PaymentMethodRefFullName { get; set; }
        public string? Memo { get; set; }
        public string? RefundAppliedToTxnAggregate { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber { get; set; }
        public int? CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth { get; set; }
        public int? CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType { get; set; }
        public int? CreditCardTxnInfoCreditCardTxnResultInfoResultCode { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnResultInfoResultMessage { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnResultInfoAvszip { get; set; }
        public string? CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch { get; set; }
        public DateTime? CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime { get; set; }
        public string? CustomFields { get; set; }
        public string? CurrencyRefListId { get; set; }
        public string? CurrencyRefName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual Account? AraccountRefList { get; set; }
        public virtual Customer? CustomerRefList { get; set; }
        public virtual PaymentMethod? PaymentMethodRefList { get; set; }
        public virtual Account? RefundFromAccountRefList { get; set; }
    }
}
