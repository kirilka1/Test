using System;
using System.Collections.Generic;

namespace TestWebApplication.WebForms
{
    public partial class CustomerWebForm : System.Web.UI.Page
    {
        CustomerHandling ch = new CustomerHandling();
        List<Customer> listCustomer = new List<Customer>();

        protected void Page_Load(object sender, EventArgs e)
        {
            listCustomer = ch.GetCustomers();
            foreach (var v in listCustomer)
            {
                ListBoxCustomer.Items.Add(v.CustomerName);
            }
        }

        protected void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForms/CustomerHandlingWebForm.aspx");
        }

        protected void ListBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListBoxCustomer.SelectedIndex;
            int customerId = listCustomer[index].CustomerId;
            Response.Redirect("~/WebForms/CustomerHandlingWebForm.aspx?customerId=" + customerId.ToString());
        }

        protected void ButtonCustomerCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForms/DirectoryWebForm.aspx");
        }
    }
}