using carservice.model;
using carservice.service.worker;
using carservice.service.orders;
using carservice.service.carservices;
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

namespace carservice.controller.admin.Delete
{
    public partial class DeleteForm : Form
    {
        ClientServiceImpl clientService = new ClientServiceImpl();
        WorkerServiceImpl workerService = new WorkerServiceImpl();
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();

        public DeleteForm()
        {
            InitializeComponent();

            delete.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(deleteId.Text.Length > 0)
            {
                delete.Enabled = true;
            }
            else { delete.Enabled = false; }
        }

        private void deleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            e.KeyChar = '\0';
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(Login.Session.TableForDelete == "Услуги")
            {
                if (carservicesService.delete(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }

            if (Login.Session.TableForDelete == "Заказы")
            {
                if (ordersService.deleteOrders(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }

            if (Login.Session.TableForDelete == "Работники")
            {
                if (workerService.delete(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }

            if (Login.Session.TableForDelete == "Клиенты")
            {
                if (clientService.delete(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }
        }
    }
}
