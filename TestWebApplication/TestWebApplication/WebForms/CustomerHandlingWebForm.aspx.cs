using System;

namespace TestWebApplication
{
    public partial class CustomerWebForm : System.Web.UI.Page
    {
        CustomerHandling ch = new CustomerHandling();
        string customerId;
        protected void Page_Load(object sender, EventArgs e)
        {
            customerId = Request.QueryString["customerId"];
            if(customerId == null)
            {
                return;
            }
            ButtonCreateEditCustomer.Text = "Изменить";
            ButtonDeleteCustomer.Visible = true;
            Customer customer = ch.GetCustomerById(customerId);
            TextBoxCustomerName.ID = "customerName";
            TextBoxCustomerName.Text = customer.CustomerName;
            TextBoxINN.ID = "inn";
            TextBoxINN.Text = customer.INN;
            TextBoxAddress.ID = "address";
            TextBoxAddress.Text = customer.Address;
        }

        protected void ButtonCreateEditCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                CustomerName = TextBoxCustomerName.Text,
                INN = TextBoxINN.Text,
                Address = TextBoxAddress.Text
            };
            switch (ButtonCreateEditCustomer.Text)
            {
                case "Создать":
                    ch.CreateCustomer(customer);
                    break;
                case "Изменить":
                    ch.EditCustomer(customerId, customer);
                    break;
                default:
                    break;
            }
            
            Response.Redirect("~/WebForms/CustomerWebForm.aspx");
        }

        protected void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            ch.DeleteCustomer(customerId);
            Response.Redirect("~/WebForms/CustomerWebForm.aspx");
        }

        protected void ButtonCancelCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForms/CustomerWebForm.aspx");
        }
    }
}