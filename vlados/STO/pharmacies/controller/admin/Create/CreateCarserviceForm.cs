using carservice.model;
using carservice.service.orders;
using carservice.service.carservices;
using carservice.service.carservicesOrders;
using carservice.service.worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace carservice.controller.admin.Create
{
    public partial class CreateCarserviceForm : Form
    {
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        CarserviceOrdersService carservicesOrdersService = new CarserviceOrdersServiceImpl();
        List<Order> orderssToSave = new List<Order>();
        List<Order> allOrderss;
        List<Worker> allWorkers;
        public int bebra = 2;
        WorkerServiceImpl workerService = new WorkerServiceImpl(); 
        public CreateCarserviceForm()
        {
            InitializeComponent();
            setWorkers();
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
            Carservice carservice = new Carservice();
            bebra++;
            carservice.Uzel = repairBox.Text;
            List<Worker> allWorkers = workerService.getAll();
            foreach (var item in allWorkers)
            {
                if (item.Name == WorkerBox.Text)
                {
                    carservice.Idworker = item.Id;
                }
            }
            carservicesService.save(carservice);
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

        private void repairBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void WorkerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }
    }
}
