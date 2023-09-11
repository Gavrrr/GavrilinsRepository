using carservice.model;
using carservice.service.carservices;
using carservice.service.carservicesOrders;
using carservice.service.client;
using carservice.service.orders;
using carservice.service.worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace carservice.controller.admin.Update
{
    public partial class UpdateOrderForm : Form
    {
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        CarserviceOrdersServiceImpl carservicesOrdersService = new CarserviceOrdersServiceImpl();
        ClientServiceImpl clientService = new ClientServiceImpl();

        List<Order> orderssToSave = new List<Order>();
        List<Order> allOrderss;
        List<Worker> allWorkers;
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        public UpdateOrderForm()
        {
            InitializeComponent();
            setOrder();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            save.Enabled = false;
        }

        private void saveEnable()
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Order orders = ordersService.getById(Convert.ToInt32(OrderBox.Text));
            orders.Cost = Convert.ToInt32(cost.Text);
            orders.DateGet = dateTimePicker1.Value;
            orders.DateDelivery = dateTimePicker2.Value;

            List<Client> allClients = clientService.getAll();
            foreach (var item in allClients)
            {
                if (item.Name == clientBox1.Text)
                {
                    orders.ClientId = item.Id;
                }
            }

            List<Carservice> allCarservices = carservicesService.getAll();
            foreach (var item in allCarservices)
            {
                if (item.Uzel == CarserviceBox.Text)
                {
                    orders.CarServiceId = item.Id;
                }
            }

            ordersService.update(orders);
            Close();
        }



        private void CreateCarservicesForm_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void setOrder()
        {
            List<Order> orders = ordersService.getAll();
            foreach (var item in orders)
            {
                OrderBox.Items.Add(item.Id);
            }
        }

        private void ClientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
            Order order = ordersService.getById(Convert.ToInt32(OrderBox.Text));
            CarserviceBox.Text = order.CarService.Uzel;
            cost.Text = order.Cost.ToString();
            clientBox1.Text = order.Client.Name;
            dateTimePicker1.Value = order.DateGet;
            dateTimePicker2.Value = order.DateDelivery;
        }

        private void OrderBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            if (cost.Text.Length > 11)
            {
                e.KeyChar = '\0';
                return;
            }
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            e.KeyChar = '\0';
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {
            if (OrderBox.Text.Length > 0 && CarserviceBox.Text.Length > 0 && cost.Text.Length > 0 && clientBox1.Text.Length > 0 && dateTimePicker1.Text.Length > 0 && dateTimePicker2.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
            saveEnable();
        }
    }
}
