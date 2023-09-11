using carservice.model;
using carservice.service.carserviceservice;
using carservice.service.client;
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
    public partial class CreateClients : Form
    {
        ClientServiceImpl clientService = new ClientServiceImpl();
        public CreateClients()
        {
            InitializeComponent();
            save.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AvtoName_TextChanged(object sender, EventArgs e)
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

        private void save_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Name = Name.Text;
            client.AvtoName = AvtoName.Text;
            client.Telephone = Number.Text;
            client.AvtoNumber = CarNumber.Text;
            clientService.save(client);
            Close();
        }

        private void CarNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
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

        private void Number_TextChanged(object sender, EventArgs e)
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

        private void CarNumber_TextChanged_1(object sender, EventArgs e)
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
    }
}
