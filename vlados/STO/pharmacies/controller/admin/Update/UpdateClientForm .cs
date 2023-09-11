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
    public partial class UpdateClientForm : Form
    {
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        CarserviceOrdersServiceImpl carservicesOrdersService = new CarserviceOrdersServiceImpl();
        ClientServiceImpl clientService = new ClientServiceImpl();

        List<Order> orderssToSave = new List<Order>();
        List<Order> allOrderss;
        List<Worker> allWorkers;
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        public UpdateClientForm()
        {
            InitializeComponent();
            setClient();
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
            Client client = clientService.getByName(ClientBox.Text);
            client.Name = Name.Text;
            client.AvtoName = AvtoName.Text;
            client.Telephone = Number.Text;
            client.AvtoNumber = CarNumber.Text;
            clientService.update(client);
            Close();
        }



        private void CreateCarservicesForm_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (ClientBox.Text.Length > 0 && Name.Text.Length > 0 && AvtoName.Text.Length > 0 && CarNumber.Text.Length > 0 && Number.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
            saveEnable();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void setClient()
        {
            List<Client> products = clientService.getAll();
            foreach (var item in products)
            {
                ClientBox.Items.Add(item.Name);
            }
        }

        private void ClientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
            Client client = clientService.getByName(ClientBox.Text);
            Name.Text = client.Name;
            AvtoName.Text = client.AvtoName;
            Number.Text = client.Telephone;
            CarNumber.Text = client.AvtoNumber;
        }

        private void ClientBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A') && (e.KeyChar <= 'Z'))
                return;
            if ((e.KeyChar >= 'a') && (e.KeyChar <= 'z'))
                return;
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я'))
                return;
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            if (e.KeyChar == (char)Keys.Space)
                return;
            e.Handled = true;
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            if (Number.Text.Length > 11)
            {
                e.KeyChar = '\0';
                return;
            }
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if ((e.KeyChar == '+') && (Number.Text.Length == 0))
                return;
            e.KeyChar = '\0';
        }

        private void CarNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Name.Text.Length > 0 && AvtoName.Text.Length > 0 && Number.Text.Length > 0 && CarNumber.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void CarNumber_TabIndexChanged(object sender, EventArgs e)
        {
            if (ClientBox.Text.Length > 0 && Name.Text.Length > 0 && AvtoName.Text.Length > 0 && CarNumber.Text.Length > 0 && Number.Text.Length > 0)
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
