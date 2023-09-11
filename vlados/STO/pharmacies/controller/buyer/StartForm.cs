using carservice.model;
using carservice.service.orders;
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

namespace carservice.controller.boyer
{
    public partial class StartForm : Form
    {
        OrdersServiceImpl ordersService = new OrdersServiceImpl();
        CarserviceServiceImpl carservicesService = new CarserviceServiceImpl();
        public StartForm()
        {
            InitializeComponent();

            var allOrderss = ordersService.getAll();
            wellcome.Text = "Добро пожаловать, " + Login.Session.CurrentClients.ClientsName + "!";
            allOrderss = ordersService.getAll();

            //if (allOrderss != null)
            //{
            //    foreach (var orders in allOrderss)
            //    {
            //        ordersBox.Items.Add(orders.Name);
            //    }
            //}

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            WhereCanBuy.Enabled = false;
            WhereCanBuyCost.Enabled = false;
        }

        private void buttonEnabled()
        {
            if(ordersBox.Text.Length > 0)
            {
                WhereCanBuy.Enabled = true;
                WhereCanBuyCost.Enabled = true;
            }
            else
            {
                WhereCanBuy.Enabled = false;
                WhereCanBuyCost.Enabled = false;
            }
        }

        //private void WhereCanBuy_Click(object sender, EventArgs e)
        //{
        //    List<Carservice> carservicess = carservicesService.WhereCanBuy(ordersBox.Text);
        //    String result = "Результат: ";
        //    //foreach(var pharmasy in carservicess)
        //    //{
        //    //    result += pharmasy.Name + " " + pharmasy.Address + "\n";
        //    //}
        //    if(result != "Результат: ")
        //    {
        //        MessageBox.Show(result);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ничего не найдено");
        //    }
        //}

        private void ordersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnabled();
        }

        private void ordersBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        //private void WhereCanBuyCost_Click(object sender, EventArgs e)
        //{
        //    List<Carservice> carservicess = carservicesService.WhereCanBuyCost(ordersBox.Text);
        //    String result = "Результат(по возрастанию цены):\n";
        //    foreach (var pharmasy in carservicess)
        //    {
        //        result += pharmasy.Name + " " + pharmasy.Address + "\n";
        //    }
        //    if (result != "Результат: ")
        //    {
        //        MessageBox.Show(result);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ничего не найдено");
        //    }
        //}

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Session.FormLogin.Visible = true;
        }
    }
}
