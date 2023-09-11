using carservice.model;
using carservice.service.avto;
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
    public partial class CreateAvtoForm : Form
    {
        AvtoServiceImpl avtoService = new AvtoServiceImpl();

        public CreateAvtoForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            save.Enabled = false;
        }

        private void saveEnable()
        {
            if (name.Text.Length > 0 && number.Text.Length > 0 && telefonNumber.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void telefonNumber_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }
        private void setClient()
        {
            List<Client> allClients = clientService.getAll();
            foreach (var item in allClients)
            {
                avtoBox.Items.Add(item.Name);
            }
        }
        private void telefonNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) 
                return;
            if ((e.KeyChar == '+') && (telefonNumber.Text.Length == 0))
                return;
            if (e.KeyChar == (char)Keys.Back) 
                return;
            if (e.KeyChar == (char)Keys.Tab) 
                return;
            e.KeyChar = '\0';
        }

        private void save_Click(object sender, EventArgs e)
        {
            Avto avto = new Avto();
            avto.Body = Body.Text;
            avto.Number = number.Text;
            avto.Brand = Brand.Text;
            avto.
            if (avtoService.saveAvto(avto))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Фирма с таким именем уже существует!");
            }

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }
    }
}
