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
    public partial class UpdateCarserviceForm : Form
    {
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        CarserviceOrdersService carservicesOrdersService = new CarserviceOrdersServiceImpl();
        List<Order> orderssToSave = new List<Order>();
        List<Order> allOrderss;
        List<Worker> allWorkers;
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        public UpdateCarserviceForm()
        {
            InitializeComponent();
            setWorkers();
            setCarservice();
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



        private void setWorkers()
        {
            allWorkers = workerService.getAll();
            if (allWorkers != null)
            {
                foreach (var worker in allWorkers)
                {
                    WorkerBox.Items.Add(worker.Name);
                }
            }
        }
        private void address_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Carservice carservice = carservicesService.getById(Convert.ToInt32(carserviceBox.Text));
            carservice.Uzel = repairBox.Text;
            List<Worker> allWorkers = workerService.getAll();
            foreach (var item in allWorkers)
            {
                if (item.Name == WorkerBox.Text)
                {
                    carservice.Idworker = item.Id;
                }
            }
            carservicesService.update(carservice);
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
        private void setCarservice()
        {
            List<Carservice> products = carservicesService.getAll();
            foreach (var item in products)
            {
                carserviceBox.Items.Add(item.Id);
            }
        }

        private void carserviceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
            Carservice carservice = carservicesService.getById(Convert.ToInt32(carserviceBox.Text));
            WorkerBox.Text = carservice.Worker.Name;
            repairBox.Text = carservice.Uzel;

        }

        private void carserviceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void repairBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repairBox.Text.Length > 0 && WorkerBox.Text.Length > 0)
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
