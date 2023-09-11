using carservice.repository;
using carservice.service.orders;
using carservice.service.client;
using carservice.service.carservices;
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
    public partial class ReadOrdersForm : Form
    {
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carserviceService = new CarserviceServiceImpl();
        ClientServiceImpl clientService = new ClientServiceImpl();

        public ReadOrdersForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dataGridView1.RowCount = ordersService.getAll().Count == 0 ? 1 : ordersService.getAll().Count;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Дата приема";
            dataGridView1.Columns[2].Name = "Дата сдачи";
            dataGridView1.Columns[3].Name = "Номер клиента";
            dataGridView1.Columns[4].Name = "Цена";
            dataGridView1.Columns[5].Name = "Услуга";


            int i = 0;
            foreach(var orders in ordersService.getAll())
            {
                dataGridView1.Rows[i].Cells[0].Value = orders.Id;
                dataGridView1.Rows[i].Cells[1].Value = orders.DateGet.Date;
                dataGridView1.Rows[i].Cells[2].Value = orders.DateDelivery.Date;
                dataGridView1.Rows[i].Cells[3].Value = clientService.GetById(orders.ClientId).Name;
                dataGridView1.Rows[i].Cells[4].Value = orders.Cost;
                dataGridView1.Rows[i].Cells[5].Value = carserviceService.getById(orders.CarServiceId).Uzel;
                i++;
            }
        }
    }
}
