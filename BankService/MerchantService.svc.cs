using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankService
{
    // NOT: "Service1" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde Service1.svc'yi veya Service1.svc.cs'yi seçin ve hata ayıklamaya başlayın.
    public class MerchantService : IMerchantService
    {
        private static List<Customer> customers = new List<Customer>();
        private static List<Merchant> merchants = new List<Merchant>();
        private static List<Terminal> terminals = new List<Terminal>();
        private static List<Sale> sales = new List<Sale>();

        // Customer işlemleri

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customer.CustomerID = customers.Count > 0 ? customers.Max(c => c.CustomerID) + 1 : 1;
            customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerName = customer.CustomerName;
                existingCustomer.CustomerSurname = customer.CustomerSurname;
                existingCustomer.Email = customer.Email;
                existingCustomer.Telephone = customer.Telephone;
                existingCustomer.Adress = customer.Adress;
            }
        }

        public void DeleteCustomer(decimal customerId)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerID == customerId);
            if (customer != null)
            {
                customers.Remove(customer);
            }
        }

        // Merchant işlemleri

        public List<Merchant> GetMerchants()
        {
            return merchants;
        }

        public void AddMerchant(Merchant merchant)
        {
            merchant.MerchantID = merchants.Count > 0 ? merchants.Max(m => m.MerchantID) + 1 : 1;
            merchants.Add(merchant);
        }

        public void UpdateMerchant(Merchant merchant)
        {
            var existingMerchant = merchants.FirstOrDefault(m => m.MerchantID == merchant.MerchantID);
            if (existingMerchant != null)
            {
                existingMerchant.MerchantName = merchant.MerchantName;
                existingMerchant.Address = merchant.Address;
                existingMerchant.Telephone = merchant.Telephone;
                existingMerchant.VergiNo = merchant.VergiNo;
            }
        }

        public void DeleteMerchant(decimal merchantId)
        {
            var merchant = merchants.FirstOrDefault(m => m.MerchantID == merchantId);
            if (merchant != null)
            {
                merchants.Remove(merchant);
            }
        }

        // Terminal işlemleri

        public List<Terminal> GetTerminals()
        {
            return terminals;
        }

        public void AddTerminal(Terminal terminal)
        {
            terminal.TerminalID = terminals.Count > 0 ? terminals.Max(t => t.TerminalID) + 1 : 1;
            terminals.Add(terminal);
        }

        public void UpdateTerminal(Terminal terminal)
        {
            var existingTerminal = terminals.FirstOrDefault(t => t.TerminalID == terminal.TerminalID);
            if (existingTerminal != null)
            {
                existingTerminal.TerminalName = terminal.TerminalName;
                existingTerminal.TerminalTypes = terminal.TerminalTypes;
                existingTerminal.SeriouslyNo = terminal.SeriouslyNo;
                existingTerminal.Situation = terminal.Situation;
            }
        }

        public void DeleteTerminal(decimal terminalId)
        {
            var terminal = terminals.FirstOrDefault(t => t.TerminalID == terminalId);
            if (terminal != null)
            {
                terminals.Remove(terminal);
            }
        }

        // Sales işlemleri

        public List<Sale> GetSales()
        {
            return sales;
        }

        public void AddSale(Sale sale)
        {
            sale.SaleID = sales.Count > 0 ? sales.Max(s => s.SaleID) + 1 : 1;
            sales.Add(sale);
        }


    }
}
