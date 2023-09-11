using carservice.service.orders;
using carservice.service.carservices;
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

namespace carservice.controller.admin.Read
{
    public partial class ReadCarserviceForm : Form
    {
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        public ReadCarserviceForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = carservicesService.getAll().Count == 0 ? 1 : carservicesService.getAll().Count;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Ремонтируемый узел";
            dataGridView1.Columns[2].Name = "Работник";

            int i = 0;
            foreach (var carservices in carservicesService.getAll())
            {
                dataGridView1.Rows[i].Cells[0].Value = carservices.Id;
                dataGridView1.Rows[i].Cells[1].Value = carservices.Uzel;
                dataGridView1.Rows[i].Cells[2].Value = workerService.findWorkerById(carservices.Idworker).Name;
                i++;
            }
        }
    }
}
