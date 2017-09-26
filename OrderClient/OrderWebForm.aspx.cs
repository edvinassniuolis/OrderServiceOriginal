using OrderClient.OrderReference;
using System;
using System.Collections.Generic;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < value; i++)
            //{
            //    txtBoxList.ElementAt(i).Text = i.ToString();
            //}
            var order = new Order()
            {
                Product = "bbb",
                CustomerName = "aaa",
                Quantity = 3
            };
            OrderServiceClient client = new OrderServiceClient();
            client.AddOrder(order);
        }
    }
}