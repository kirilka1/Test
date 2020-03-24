using System;
using System.Collections.Generic;

namespace TestWebApplication
{
    public partial class DirectoryWebForm : System.Web.UI.Page
    {
        CustomerHandling ch = new CustomerHandling();
        AccountHandling ah = new AccountHandling();
        List<Customer> listCustomer = new List<Customer>();
        protected void Page_Load(object sender, EventArgs e)
        {
            listCustomer = ch.GetCustomers();
            foreach (var v in listCustomer)
            {
                DropDownListCustomer.Items.Add(v.CustomerName);
            }
        }

        protected void ButtonGetCounts_Click(object sender, EventArgs e)
        {
            int index = DropDownListCustomer.SelectedIndex;
            int customerId = listCustomer[index].CustomerId;
            ah.GetAccountsByCustomerId(customerId);
        }

        protected void ButtonCustomerHandling_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForms/CustomerWebForm.aspx");
        }
    }
}