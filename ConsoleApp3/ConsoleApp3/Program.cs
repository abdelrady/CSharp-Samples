using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp3
{
    class Program
    {
        public static int Dummy
        {
            get
            {
                var propertyName = MethodBase.GetCurrentMethod().Name.Substring(4);
                Console.WriteLine(propertyName);
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Dummy);
            try
            {
                var RefundData =
                "{\"TenantId\":2,\"ContactName\":null,\"ContactId\":53,\"PaymentContactId\":53,\"OrganizationId\":null,\"SaveOnContactId\":53,\"SaveOnOrganizationId\":null,\"PaymentId\":0,\"PaymentProfileId\":null,\"ManageDpmProfilesAction\":null,\"AuthProfilePageToken\":null,\"AuthProfileUrl\":null,\"ShowGateways\":false,\"ReadOnlyGateways\":false,\"PaymentGatewayId\":17,\"ConfigInfoJson\":null,\"PaymentGatewayTypeId\":3,\"CreditCardInfo\":null,\"CheckNumber\":null,\"StorePaymentInfoForFuture\":false,\"PayByNewCard\":true,\"TokenId\":null,\"Capture\":false,\"SimResponse\":{\"MD5Hash\":null,\"ResponseCode\":null,\"Message\":null,\"Approved\":false,\"InvoiceNumber\":null,\"Amount\":0.0,\"TransactionID\":null,\"AuthorizationCode\":null,\"CardNumber\":null,\"CardNumberDPM\":null,\"CardType\":null},\"EPaymentTransactionId\":0,\"DataDescriptor\":\"COMMON.ACCEPT.INAPP.PAYMENT\",\"DataValue\":\"eyJjb2RlIjoiNTBfMl8wNjAwMDUyOENBMjJEMzhFQzRGQ0IyMEFCNzJEMUE3QzU2NjA1Q0MyMEY0MjhCNjIwMkQ5NkExMUE3QjlEOUY0MUU4QUVGMEI2MzM0QTJEMDQwNTNDMDBFMTM5NjYwRTI3REFCQkFDIiwidG9rZW4iOiI5NTI3NzIyMzIzMjk5ODIwMTA0NjAzIiwidiI6IjEuMSJ9\",\"IsTestCard\":true,\"CardType\":null,\"CardLast4\":\"0027\",\"CardExpMonth\":null,\"CardExpYear\":null,\"CardCvc\":null,\"PaymentDate\":null,\"Amount\":25.00,\"VoluntaryAmount\":0.0,\"Currency\":null,\"GatewayAmounts\":null,\"IsBankCharge\":false,\"IsSavingsAccount\":false,\"PurchaseId\":0,\"OpenInvoices\":null,\"InvoicePaymentSelection\":null,\"ScheduledBillingItems\":null,\"Company\":null,\"FirstName\":null,\"LastName\":null,\"Address\":null,\"Address1\":null,\"Address2\":null,\"City\":null,\"StateProvince\":null,\"PostalCode\":null,\"CountryCode\":\"US\",\"Email\":\"rady02@mailinator.com\",\"Phone\":null,\"HttpReferer\":\"https://test.localtest.me:44300/ap/donate/qep01P2g\"}";
                var model = JsonConvert.DeserializeObject<ExternalSourcePaymentModel>(RefundData);
                Console.WriteLine(model.CardType);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

    }

    public class ExternalSourcePaymentModel 
    {
        
        public int TenantId { get; set; }

        public string ContactName { get; set; }

        public int? ContactId { get; set; }

        
        public int? PaymentContactId { get; set; }

        
        public int? OrganizationId { get; set; }

        
        public int? SaveOnContactId { get; set; }

        
        public int? SaveOnOrganizationId { get; set; }

        //
        /// <summary>
        /// Not sure we will use this - probably delete later
        /// </summary>
        public int PaymentId { get; set; }

        public int? PaymentProfileId { get; set; }

        public string ManageDpmProfilesAction { get; set; }

        
        public string AuthProfilePageToken { get; set; }

        
        public string AuthProfileUrl { get; set; }

        
        public bool ShowGateways { get; set; }

        
        public bool ReadOnlyGateways { get; set; }

        public int? PaymentGatewayId { get; set; }

        
        public string ConfigInfoJson { get; set; }

        
        public SystemPaymentGatewayTypeOption? PaymentGatewayTypeId { get; set; }

        public object CreditCardInfo { get; set; }

        public string CheckNumber { get; set; }

        public bool StorePaymentInfoForFuture { get; set; }

        
        public bool PayByNewCard => true;

        
        public string TokenId { get; set; }

        
        public bool? Capture { get; set; }

         // used by Authorize.Net DPM method
        public SIMResponse SimResponse { get; set; }

         // used by Authorize.Net DPM method
        public int EPaymentTransactionId { get; set; }

         // used by Authorize.Net Accept.js
        public string DataDescriptor { get; set; }

         // used by Authorize.Net Accept.js
        public string DataValue { get; set; }

         // used by Authorize.Net Accept.js
        public bool IsTestCard { get; set; }

        
        public string CardType { get; set; }

        
        public string CardLast4 { get; set; }

        
        public int? CardExpMonth { get; set; }

        
        public int? CardExpYear { get; set; }

        
        public string CardCvc { get; set; }

        public DateTime? PaymentDate { get; set; }

        public decimal Amount { get; set; }

        
        public decimal VoluntaryAmount { get; set; }

        
        public string Currency { get; set; }

        
        public List<GatewayAmount> GatewayAmounts { get; set; }

        
        public bool IsBankCharge { get; set; }

        // billhighway backoffice Chech/ACH payment field
        
        public bool IsSavingsAccount { get; set; }

        /// <summary>
        /// Optional parameter in case we are filtering to pay for a single invoice
        /// </summary>
        public int PurchaseId { get; set; }

        public List<OpenInvoiceItems> OpenInvoices { get; set; }

        public object InvoicePaymentSelection { get; set; }

        
        public List<ScheduledBillingItems> ScheduledBillingItems { get; set; }

        // Authorize.Net wants billing info so we copy these values to it's model
        
        public string Company { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public string Address1 { get; set; }
        
        public string Address2 { get; set; }
        
        public string City { get; set; }
        
        public string StateProvince { get; set; }
        
        public string PostalCode { get; set; }
        
        public string CountryCode { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        public string HttpReferer { get; set; } // where did the payment request originate from

    }
    public enum SystemPaymentGatewayTypeOption : byte
    {
        External_Non_Integrated = 0, // Should be referred to in UI as "Third-Party / External Payment Processor"
        Stripe = 1, // Should be referred to in UI as "Integrated Payment Processing"
        Authorize_NET_CIM = 2,
        Authorize_NET_DPM = 3,
        Billhighway = 4,
    }

    public class ScheduledBillingItems 
    {
        public bool IsSelected { get; set; }

        public int ScheduledBillingId { get; set; }

        public int? PaymentProfileId { get; set; }
    }

    public class OpenInvoiceItems 
    {
        public bool IsSelected { get; set; }

        public int PurchaseId { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime PurchaseDate { get; set; }

        public List<PurchaseItemCollectionModel> VoluntaryItems { get; set; }

        public decimal Amount { get; set; }

        public decimal Balance { get; set; }

        public decimal BalanceRO { get; set; }

        public int Id => PurchaseId;

        public List<int> ScheduledBillings { get; set; }

    }


    public class GatewayAmount
    {
        public int PaymentGatewayId { get; set; }
        public decimal Amount { get; set; }
        public string TokenId { get; set; }
    }

    public class SIMResponse 
    {
        string _merchantHash;
        
        /// <summary>
        /// Validates that what was passed by Auth.net is valid
        /// </summary>
        public bool Validate(string merchantHash, string apiLogin)
        {
            //return Crypto.IsMatch(merchantHash, apiLogin, this.TransactionID, this.Amount, this.MD5Hash);
            return true;
        }


        public string MD5Hash
        {
            get
            {
                return FindKey("x_MD5_Hash");
            }
        }

        public string ResponseCode
        {
            get
            {
                return FindKey("x_response_code");
            }
        }
        public string Message
        {
            get
            {
                return FindKey("x_response_reason_text");
            }
        }

        public bool Approved
        {
            get
            {
                return this.ResponseCode == "1";
            }
        }

        public string InvoiceNumber
        {
            get
            {
                return FindKey(ApiFields.InvoiceNumber);
            }
        }

        public decimal Amount
        {
            get
            {
                var sAmount = FindKey(ApiFields.Amount);
                decimal result = 0.00M;
                decimal.TryParse(sAmount, out result);
                return result;
            }
        }

        public string TransactionID
        {
            get
            {
                return FindKey(ApiFields.TransactionID);
            }
        }

        public string AuthorizationCode
        {
            get
            {
                return FindKey(ApiFields.AuthorizationCode);
            }
        }

        public string CardNumber
        {
            get
            {
                return FindKey(ApiFields.CreditCardNumber);
            }
        }

        public string CardNumberDPM
        {
            get
            {
                return FindKey(ApiFields.CreditCardNumberDPM);
            }
        }

        public string CardType
        {
            get
            {
                return FindKey(ApiFields.CreditCardType);
            }
        }

        string FindKey(string key)
        {
            string result = null;

            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("<li>Code = {0}", this.ResponseCode);
            sb.AppendFormat("<li>Auth = {0}", this.AuthorizationCode);
            sb.AppendFormat("<li>Message = {0}", this.Message);
            sb.AppendFormat("<li>TransID = {0}", this.TransactionID);
            sb.AppendFormat("<li>Approved = {0}", this.Approved);
            return sb.ToString();
        }
    }
    public class ApiFields
    {
        public const string CardholderAuthenticationValue = "x_cardholder_authentication_value";
        public const string FooterEmailReceipt = "x_footer_email_receipt";
        public const string EncapChar = "x_encap_char";
        public const string HeaderEmailReceipt = "x_header_email_receipt";
        public const string AuthenticationIndicator = "x_authentication_indicator";

        public const string BankABACode = "x_bank_aba_code";
        public const string BankAcctNum = "x_bank_acct_num";
        public const string BankAcctType = "x_bank_acct_type";
        public const string BankName = "x_bank_name";
        public const string BankAcctName = "x_bank_acct_name";
        public const string EcheckType = "x_echeck_type";
        public const string BankCheckNumber = "x_bank_check_number";


        public const string LineItem = "x_line_item";
        public const string ShipToAddress = "x_ship_to_address";
        public const string ShipToCity = "x_ship_to_city";
        public const string ShipToState = "x_ship_to_state";
        public const string ShipToZip = "x_ship_to_zip";
        public const string ShipToCountry = "x_ship_to_country";
        public const string ShipToCompany = "x_ship_to_company";
        public const string ShipToFirstName = "x_ship_to_first_name";
        public const string ShipToLastName = "x_ship_to_last_name";
        public const string TestRequest = "x_test_request";


        public const string Type = "x_type";
        public const string Version = "x_version";
        /// <summary>
		/// The merchant's unique API Login ID
		/// </summary>
		public const string ApiLogin = "x_login";

        /// <summary>
        /// The merchant's unique Transaction Key
        /// </summary>	
        public const string TransactionKey = "x_tran_key";

        /// <summary>
        /// True, False
        /// </summary>
        public const string AllowPartialAuth = "x_allow_partial_Auth";

        /// <summary>
        /// Whether to return the data in delimited fashion
        /// </summary>
        public const string DelimitData = "x_delim_data";

        /// <summary>
        /// If the return from AuthorizeNet is delimited - this is the character to use. Default is pipe
        /// </summary>
        public const string DelimitCharacter = "x_delim_char";


        /// <summary>
        /// The relay response - leave this set as TRUE
        /// </summary>
        public const string RelayResponse = "x_relay_response";

        public ApiFields()
        {
            ApiKeys = new List<string>();

            ApiKeys.Add("x_login");

            ApiKeys.Add("x_tran_key");

            ApiKeys.Add("x_allow_partial_Auth");

            ApiKeys.Add("x_delim_data");

            ApiKeys.Add("x_delim_char");

            ApiKeys.Add("x_relay_response");

            ApiKeys.Add("x_version");

            ApiKeys.Add("x_type");

            ApiKeys.Add("x_method");

            ApiKeys.Add("x_recurring_billing");

            ApiKeys.Add("x_amount");

            ApiKeys.Add("x_card_num");

            ApiKeys.Add("x_exp_date");

            ApiKeys.Add("x_card_code");

            ApiKeys.Add("x_trans_id");

            ApiKeys.Add("x_split_tender");

            ApiKeys.Add("x_auth_code");

            ApiKeys.Add("x_test_request");

            ApiKeys.Add("x_duplicate_window");

            ApiKeys.Add("x_invoice_num");

            ApiKeys.Add("x_description");

            ApiKeys.Add("x_first_name");

            ApiKeys.Add("x_last_name");

            ApiKeys.Add("x_company");

            ApiKeys.Add("x_address");

            ApiKeys.Add("x_city");

            ApiKeys.Add("x_state");

            ApiKeys.Add("x_zip");

            ApiKeys.Add("x_country");

            ApiKeys.Add("x_phone");

            ApiKeys.Add("x_fax");

            ApiKeys.Add("x_email");

            ApiKeys.Add("x_cust_id");

            ApiKeys.Add("x_cust_ip");

            ApiKeys.Add("x_ship_to_first_name");

            ApiKeys.Add("x_ship_to_last_name");

            ApiKeys.Add("x_ship_to_company");

            ApiKeys.Add("x_ship_to_address");

            ApiKeys.Add("x_ship_to_city");

            ApiKeys.Add("x_ship_to_state");

            ApiKeys.Add("x_ship_to_zip");

            ApiKeys.Add("x_ship_to_country");

            ApiKeys.Add("x_tax");
            ApiKeys.Add("x_frieght");
            ApiKeys.Add("x_duty");
            ApiKeys.Add("x_tax_exempt");
            ApiKeys.Add("x_po_num");


        }

        public List<string> ApiKeys
        {
            get;
            set;
        }



        /// <summary>
        /// Required - The merchant's transaction version
        /// </summary>
        public const string ApiVersion = "x_version";

        /// <summary>
        /// The type of transaction:
        /// AUTH_CAPTURE (default), AUTH_ONLY, CAPTURE_ONLY, CREDIT, PRIOR_AUTH_CAPTURE, VOID
        /// </summary>
        public const string TransactionType = "x_type";

        /// <summary>
        /// CC or ECHECK
        /// </summary>
        public const string Method = "x_method";

        /// <summary>
        /// The recurring billing status
        /// </summary>
        public const string RecurringBilling = "x_recurring_billing";

        /// <summary>
        /// The amount of the transaction
        /// </summary>
        public const string Amount = "x_amount";
        /// <summary>
        /// The credit card number - between 13 and 16 digits without spaces. When x_type=CREDIT, only the last four digits are required
        /// </summary>
        public const string CreditCardNumber = "x_card_num";
        /// <summary>
        /// The expiration date - MMYY, MM/YY, MM-YY, MMYYYY, MM/YYYY, MM-YYYY
        /// </summary>
        public const string CreditCardExpiration = "x_exp_date";
        /// <summary>
        /// The three- or four-digit number on the back of a credit card (on the front for American Express).
        /// </summary>
        public const string CreditCardCode = "x_card_code";
        /// <summary>
        /// The payment gateway assigned transaction ID of an original transaction - Required only for CREDIT, PRIOR_ AUTH_ CAPTURE, and VOID transactions
        /// </summary>
        public const string TransactionID = "x_trans_id";
        /// <summary>
        /// The credit card type
        /// </summary>
        public const string CreditCardType = "x_card_type";
        /// <summary>
        /// The DPM credit card number (returns only last 4)
        /// </summary>
        public const string CreditCardNumberDPM = "x_account_number";
        /// <summary>
        /// The payment gateway-assitned ID assigned when the original transaction includes  two or more partial payments. This is the identifier that is used to group transactions that are part of a split tender order.
        /// </summary>
        public const string SplitTenderId = "x_split_tender_id";
        /// <summary>
        /// The authorization code of an original transaction not authorized on the payment gateway
        /// </summary>
        public const string AuthorizationCode = "x_auth_code";
        /// <summary>
        /// The request to process test transactions
        /// </summary>
        public const string IsTestRequest = "x_test_request";
        /// <summary>
        /// The window of time after the submission of a transaction that a duplicate transaction can not be submitted
        /// </summary>
        public const string DuplicateWindowTime = "x_duplicate_window";

        /// <summary>
        /// The merchant assigned invoice number for the transaction
        /// </summary>
        public const string InvoiceNumber = "x_invoice_num";

        /// <summary>
        /// The transaction description
        /// </summary>
        public const string Description = "x_description";


        public const string FirstName = "x_first_name";

        public const string LastName = "x_last_name";

        public const string Company = "x_company";

        public const string Address = "x_address";

        public const string City = "x_city";

        public const string State = "x_state";

        public const string Zip = "x_zip";

        public const string Country = "x_country";

        public const string Phone = "x_phone";

        public const string Fax = "x_fax";

        public const string Email = "x_email";

        /// <summary>
        /// The ID of the Customer as relates to your application
        /// </summary>
        public const string CustomerID = "x_cust_id";

        public const string CustomerIPAddress = "x_cust_ip";


        public const string ShipFirstName = "x_ship_to_first_name";

        public const string ShipLastName = "x_ship_to_last_name";

        public const string ShipCompany = "x_ship_to_company";

        public const string ShipAddress = "x_ship_to_address";

        public const string ShipCity = "x_ship_to_city";

        public const string ShipState = "x_ship_to_state";

        public const string ShipZip = "x_ship_to_zip";

        public const string ShipCountry = "x_ship_to_country";


        public const string Tax = "x_tax";
        public const string Freight = "x_frieght";
        public const string Duty = "x_duty";
        public const string TaxExempt = "x_tax_exempt";
        public const string PONumber = "x_po_num";



        public bool ApiContainsKey(string key)
        {

            return ApiKeys.Contains(key);
        }
    }

    public class PurchaseItemCollectionModel 
    {
        public PurchaseItemCollectionModel()
        {
            DiscountItems = new List<DiscountItemModel>();
        }

        public int PurchaseItemId { get; set; }

        public int PurchaseId { get; set; }

        
        public int AuditId { get; set; }

        
        public bool IsModified { get; set; }

        
        public bool IsSelected { get; set; }

        public bool IsDeletable { get; set; }

        
        public int? DocumentGenerationTemplateId { get; set; }

        
        public List<TaxItemModel> TaxItems { get; set; }

        public int SaleableItemId { get; set; }

        public string SaleableItemName { get; set; }

        public string Description { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal ShippingAmount { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal Total { get; set; }

        public List<DiscountItemModel> DiscountItems { get; set; }

         // for BackOfficeScreenNames.FinancePurchaseItemDiscount screen
        public bool DisallowEditDiscount { get; set; }

        
        public bool DiscountReadOnly => DisallowEditDiscount || BlockDiscount;

         // Disallow editing discount when discont account not set up
        public bool BlockDiscount { get; set; }

         // for BackOfficeScreenNames.FinancePurchaseItemDiscount screen
        public decimal ItemDiscountAmount { get; set; }

         // for BackOfficeScreenNames.FinancePurchaseItemDiscount screen
        public decimal ItemDiscountPercent { get; set; }

         // This is for checking deletes
        public bool IsDeleted { get; set; }

        
        public bool ShowNote { get { return BlockDiscount; } }

        
        public string Note { get { return "The discount account is not set. Please go to Setup to setup a discount account"; } }

        //Saleable item taxset properties
        
        public List<int> RegionIds { get; set; }
        
        public int? TaxSetId { get; set; }
        
        public decimal ItemTaxSetFloatAmount { get; set; }
        
        public decimal ItemTaxSetRate { get; set; }
        
        public bool IsVoluntary { get; set; }

        
        public int? ScheduledBillingId { get; set; }

        
        public bool AttachedToMembership { get; set; }

    }

    public class TaxItemModel 
    {
        public int PurchaseItemTaxItemId { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public int PurchaseItemId { get; set; }
        public int TaxItemId { get; set; }
    }

    public class DiscountItemModel 
    {
        public int DiscountItemId { get; set; }

        public int AuditId { get; set; }

        public bool IsModified { get; set; }

        public bool IsDeleted { get; set; }

        public int FeeItemId { get; set; }

        public int? DiscountId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal? DiscountNewPrice { get; set; }

    }
}
