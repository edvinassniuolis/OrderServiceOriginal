using OrderClient.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web.UI.WebControls;

namespace OrderClient
{
    public partial class OrderWebForm : System.Web.UI.Page
    {
        public int value = 2;
        public List<TextBox> txtBoxList = new List<TextBox>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewButton_Click(object sender, EventArgs e)
        {
            OrderServiceClient client = new OrderServiceClient();
            var list = client.ListOrders();

            //IdTextBox.Text = list.ElementAt(0).Id.ToString();
            //NameTextBox.Text = list.ElementAt(0).CustomerName;
            //ProductTextBox.Text = list.ElementAt(0).Product;
            //QuantityTextBox.Text = list.ElementAt(0).Quantity.ToString();

            //OrderServiceClient client = new OrderServiceClient();
            //var list = client.TestMes();
            //IdTextBox.Text = list.ElementAt(0);
        }

        protected void ViewOrdersBttn_Click(object sender, EventArgs e)
        {
            try
            {
                OrderServiceClient client = new OrderServiceClient();
                var list = client.ListOrders();

                OrderIdLbl.Text = list.ElementAt(0).Id.ToString();
                CustomerNameLbl.Text = list.ElementAt(0).CustomerName;
                ProductLbl.Text = list.ElementAt(0).Product;
                QuantityLbl.Text = list.ElementAt(0).Quantity.ToString();
            }
            catch (CommunicationException exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
    }
}