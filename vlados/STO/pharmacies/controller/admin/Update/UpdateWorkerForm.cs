using carservice.model;
using carservice.service.carservices;
using carservice.service.carservicesOrders;
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
    public partial class UpdateWorkerForm : Form
    {
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        CarserviceOrdersService carservicesOrdersService = new CarserviceOrdersServiceImpl();
        List<Order> orderssToSave = new List<Order>();
        List<Order> allOrderss;
        List<Worker> allWorkers;
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        public UpdateWorkerForm()
        {
            InitializeComponent();
            setWorker();
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
            Worker worker = workerService.GetByName(WorkerBox.Text);
            worker.Name = Name.Text;
            worker.Experience = Convert.ToInt32(experience.Text);
            worker.Jobtitle = Post.Text;
            List<Carservice> allcarservice = carservicesService.getAll();
            workerService.update(worker);
            Close();

        }



        private void CreateCarservicesForm_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (WorkerBox.Text.Length > 0 && Name.Text.Length > 0 && experience.Text.Length > 0 && Post.Text.Length > 0)
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
        private void setWorker()
        {
            List<Worker> workers = workerService.getAll();
            foreach (var item in workers)
            {
                WorkerBox.Items.Add(item.Name);
            }
        }

        private void carserviceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
            Worker worker = workerService.GetByName(WorkerBox.Text);
            Name.Text = worker.Name;
            experience.Text = worker.Experience.ToString();
            Post.Text = worker.Jobtitle;
        }

        private void WorkerBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void experience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            if (experience.Text.Length > 11)
            {
                e.KeyChar = '\0';
                return;
            }
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            e.KeyChar = '\0';
        }

        private void Post_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
