using carservice.model;
using carservice.service.carservices;
using carservice.service.carserviceservice;
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

namespace carservice.controller.admin.Create
{
    public partial class CreateWorker : Form
    {
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        CarserviceServiceImpl carserviceService = new CarserviceServiceImpl();
        public CreateWorker()
        {
            InitializeComponent();
            save.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void save_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Name = Name.Text;
            worker.Experience = Convert.ToInt32(experience.Text);
            worker.Jobtitle = Post.Text;
            workerService.save(worker);
            Close();
        }

        private void CreateWorker_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (Name.Text.Length > 0 && experience.Text.Length > 0 && Post.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
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
