using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankService
{
    // NOT: "IService1" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    [ServiceContract]
    public interface IMerchantService
    {
        // Customer CRUD işlemleri
        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract]
        void UpdateCustomer(Customer customer);

        [OperationContract]
        void DeleteCustomer(decimal customerId);

        // Merchant CRUD işlemleri
        [OperationContract]
        List<Merchant> GetMerchants();

        [OperationContract]
        void AddMerchant(Merchant merchant);

        [OperationContract]
        void UpdateMerchant(Merchant merchant);

        [OperationContract]
        void DeleteMerchant(decimal merchantId);

        // Terminal CRUD işlemleri
        [OperationContract]
        List<Terminal> GetTerminals();

        [OperationContract]
        void AddTerminal(Terminal terminal);

        [OperationContract]
        void UpdateTerminal(Terminal terminal);

        [OperationContract]
        void DeleteTerminal(decimal terminalId);

        // Sales işlemleri
        [OperationContract]
        List<Sale> GetSales();

        [OperationContract]
        void AddSale(Sale sale);
    }


    [DataContract]
    public class Customer
    {
        [DataMember]
        public decimal CustomerID { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string CustomerSurname { get; set; }

        [DataMember]
        public string Email { get; set; }


        [DataMember]
        public string Telephone { get; set; }


        [DataMember]
        public string Adress { get; set; }
    }


    [DataContract]
    public class Merchant
    {
        [DataMember]
        public decimal MerchantID { get; set; }


        [DataMember]
        public Nullable<decimal> CustomerID { get; set; } // Customer ile ilişkilendirilen alan

        [DataMember]
        public string MerchantName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Telephone { get; set; }

        [DataMember]
        public string VergiNo { get; set; }

    }

    [DataContract]
    public class Terminal
    {
        [DataMember]
        public decimal TerminalID { get; set; }


        [DataMember]
        public Nullable<decimal> MerchantID { get; set; } // Merchant ile ilişkilendirilen alan

        [DataMember]
        public string TerminalName { get; set; }

        [DataMember]
        public string TerminalTypes { get; set; }

        [DataMember]
        public string SeriouslyNo { get; set; }


        [DataMember]
        public string Situation { get; set; }
    }

    [DataContract]
    public class Sale
    {
        [DataMember]
        public decimal SaleID { get; set; }

        [DataMember]
        public Nullable<decimal> TerminalID { get; set; } // Terminal ile ilişkilendirilen alan

        [DataMember]
        public Nullable<decimal> SalesAmount { get; set; }

        [DataMember]
        public Nullable<System.DateTime> SaleDate { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public string TransactionType { get; set; }

    }

}