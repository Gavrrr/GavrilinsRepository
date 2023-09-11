using carservice.controller.admin.Create;
using carservice.controller.admin.Update;
using carservice.controller.admin.Delete;
using carservice.controller.admin.Read;
using carservices.controller.admin.Read;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carservice.model;
using carservice.service.carservices;
using carservice.service.orders;
using carservice.service.worker;
using carservice.service.client;
using static System.Collections.Specialized.BitVector32;

namespace carservice.controller.admin
{
    public partial class StartForm : Form
    {
        CarserviceServiceImpl carserviceService = new CarserviceServiceImpl();
        ClientServiceImpl clientService = new ClientServiceImpl();
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        OrdersServiceImpl orderService = new OrdersServiceImpl();
        public StartForm()
        {
            InitializeComponent();
            wellcome.Text = "Добро пожаловать, " + Login.Session.CurrentUser.UserName + "!";

            table.Items.Add("Услуги");
            table.Items.Add("Заказы");
            table.Items.Add("Работники");
            table.Items.Add("Клиенты");

            Create.Enabled = false;
            Read.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Session.FormLogin.Visible = true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Login.Session.TableForAdmin = table.Text;

            if(Login.Session.TableForAdmin == "Услуги")
            {
                CreateCarserviceForm form = new CreateCarserviceForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Заказы")
            {
                CreateOrdersForm form = new CreateOrdersForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Работники")
            {
                CreateWorker form = new CreateWorker();
                form.ShowDialog();
            }


            if (Login.Session.TableForAdmin == "Клиенты")
            {
                CreateClients form = new CreateClients();
                form.ShowDialog();
            }
        }

        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Create.Text.Length > 0 && Read.Text.Length > 0 && Update.Text.Length > 0 && Delete.Text.Length > 0)
            {
                Create.Enabled = true;
                Read.Enabled = true;
                Update.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                Create.Enabled = false;
                Read.Enabled = false;
                Update.Enabled = false;
                Delete.Enabled = false;
            }
        }

        private void table_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void Read_Click(object sender, EventArgs e)
        {
            Login.Session.TableForAdmin = table.Text;

            if (Login.Session.TableForAdmin == "Услуги")
            {
                ReadCarserviceForm form = new ReadCarserviceForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Заказы")
            {
                ReadOrdersForm form = new ReadOrdersForm();
                form.ShowDialog();
            }


            if (Login.Session.TableForAdmin == "Работники")
            {
                ReadWorkersForm form = new ReadWorkersForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Клиенты")
            {
                ReadClientsForm form = new ReadClientsForm();
                form.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Login.Session.TableForDelete = table.Text;
            DeleteForm form = new DeleteForm();
            form.ShowDialog();
        }

        private void wellcome_Click(object sender, EventArgs e)
        {

        }
        private void Update_Click(object sender, EventArgs e)
        {
            Login.Session.TableForAdmin = table.Text;

            if (Login.Session.TableForAdmin == "Услуги")
            {
                    UpdateCarserviceForm form = new UpdateCarserviceForm();
                    form.ShowDialog();

            }

            if (Login.Session.TableForAdmin == "Клиенты")
            {

                    UpdateClientForm form = new UpdateClientForm();
                    form.ShowDialog();

            }

            if (Login.Session.TableForAdmin == "Заказы")
            {

                    UpdateOrderForm form = new UpdateOrderForm();
                    form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Работники")
            {
                UpdateWorkerForm form = new UpdateWorkerForm();
                form.ShowDialog();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Client client = clientService.getByName(textBox1.Text);
                String result = "Результат: ";
                result += client.Name + " " + client.Telephone + " " + client.AvtoNumber + " " + client.AvtoName;
                if (result != "Результат: ")
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }
            else if (radioButton2.Checked)
            {
                List<Client> clients = clientService.getByAvtoNumber(textBox2.Text);
                String result = "Результат: ";
                foreach (var client in clients)
                {
                    result += client.Name + " " + client.Telephone + " " + client.AvtoNumber + " " + client.AvtoName + "\n";
                }
                if (result != "Результат: ")
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }
            else if (radioButton3.Checked)
            {
                Order order = orderService.getById(Convert.ToInt32(textBox3.Text));
                String result = "Результат: " + order.Client.Name + " " + order.CarService.Uzel + "\n";
  
                if (result != "Результат: ")
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }

            else if (radioButton4.Checked)
            {
                List<Order> orders = orderService.findByDate(dateTimePicker1.Value);
                String result = "Результат: ";
                foreach (var order in orders)
                {
                    result += clientService.GetById(order.ClientId).Name + "\n";
                }
                if (result != "Результат: ")
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }

            else if (radioButton5.Checked)
            {
                List<Order> orders = orderService.findByRangeDate(dateTimePicker2.Value, dateTimePicker3.Value);
                String result = "Результат: ";
                foreach (var order in orders)
                {
                    result += clientService.GetById(order.ClientId).Name + "\n";
                }
                if (result != "Результат: ")
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }
            else if (radioButton6.Checked)
            {
                int idForSearch;
                try
                {
                    idForSearch = Convert.ToInt32(textBox3.Text);
                }
                catch
                {
                    idForSearch = 228;
                }
                List<Order> orders = orderService.findFilteredOrders(textBox1.Text, textBox2.Text, idForSearch, dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value);
                String result = "Результат: ";
                foreach (var order in orders)
                {
                    result += clientService.GetById(order.ClientId).Name + "\n";
                }
                if (result != "Результат: ")
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }
        }
    }
}
