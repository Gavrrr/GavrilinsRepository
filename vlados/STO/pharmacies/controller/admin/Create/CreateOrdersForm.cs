using carservice.enums;
using carservice.model;
using carservice.repository;
using carservice.service.worker;
using carservice.service.orders;
using carservice.service.client;
using carservice.service.carservices;
using carservice.service.carservicesOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carservice.service.carserviceservice;

namespace carservice.controller.admin.Create
{
    public partial class CreateOrdersForm : Form
    {
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        ClientServiceImpl clientService = new ClientServiceImpl();
        CarserviceOrdersServiceImpl carservicesOrdersService = new CarserviceOrdersServiceImpl();
        OrdersServiceImpl ordersService = new OrdersServiceImpl();

        List<Carservice> CarserviceToSave = new List<Carservice>();
        List<Carservice> allCarservice = new List<Carservice>();
        public CreateOrdersForm()
        {
            InitializeComponent();

            allCarservice = carservicesService.getAll();

            setClients();
            setCarservicesList();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            save.Enabled = false;
        }

        private void setCarservicesList()
        {
            List<Carservice> carservice = carservicesService.getAll();
            foreach (var item in carservice)
            {
                CarserviceBox.Items.Add(item.Uzel);
            }
        }

        private void setClients()
        {
            List<Client> allClients = clientService.getAll();
            foreach (var item in allClients)
            {
                clientBox.Items.Add(item.Name);
            }
        }


        private void saveEnable()
        {
            
        }

        private void addEnable()
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Order orders = new Order();
            orders.Cost = Convert.ToInt32(cost.Text);
            orders.DateGet= dateTimePicker1.Value;
            orders.DateDelivery= dateTimePicker2.Value;

            List<Client> allClients = clientService.getAll();
            foreach (var item in allClients)
            {
                if (item.Name == clientBox.Text)
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

            ordersService.saveOrders(orders);
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void typeOfPackaging_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void methodOfConsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void avtoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void typeOfPackaging_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void methodOfConsumption_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {
            if (CarserviceBox.Text.Length > 0 && cost.Text.Length > 0 && clientBox.Text.Length > 0 && dateTimePicker1.Text.Length > 0 && dateTimePicker2.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
            saveEnable();
        }

        private void avtoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void CarserviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEnable();
        }


        private void contraindications_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarserviceBox_TextChanged(object sender, EventArgs e)
        {
            if (CarserviceBox.Text.Length > 0 && cost.Text.Length > 0 && clientBox.Text.Length > 0 && dateTimePicker1.Text.Length > 0 && dateTimePicker2.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
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

        private void clientBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';

        }

        private void clientBox_TextChanged(object sender, EventArgs e)
        {
            if (CarserviceBox.Text.Length > 0 && cost.Text.Length > 0 && clientBox.Text.Length > 0 && dateTimePicker1.Text.Length > 0 && dateTimePicker2.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            if (CarserviceBox.Text.Length > 0 && cost.Text.Length > 0 && clientBox.Text.Length > 0 && dateTimePicker1.Text.Length > 0 && dateTimePicker2.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (CarserviceBox.Text.Length > 0 && cost.Text.Length > 0 && clientBox.Text.Length > 0 && dateTimePicker1.Text.Length > 0 && dateTimePicker2.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }
    }
}
