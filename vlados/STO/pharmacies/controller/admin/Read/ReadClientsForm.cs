using carservice.service.carserviceservice;
using carservice.service.client;
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
    public partial class ReadClientsForm : Form
    {
        ClientServiceImpl clientService = new ClientServiceImpl();
        public ReadClientsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dataGridView1.RowCount = clientService.getAll().Count == 0 ? 1 : clientService.getAll().Count;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "ФИО";
            dataGridView1.Columns[2].Name = "Название автомобиля";
            dataGridView1.Columns[3].Name = "Номер автомобиля";
            dataGridView1.Columns[4].Name = "Телефон";

            int i = 0;
            foreach (var client in clientService.getAll())
            {
                dataGridView1.Rows[i].Cells[0].Value = client.Id;
                dataGridView1.Rows[i].Cells[1].Value = client.Name;
                dataGridView1.Rows[i].Cells[2].Value = client.AvtoName;
                dataGridView1.Rows[i].Cells[3].Value = client.AvtoNumber;
                dataGridView1.Rows[i].Cells[4].Value = client.Telephone;
                i++;
            }

        }
    }
}
