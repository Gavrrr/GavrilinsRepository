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
            wellcome.Text = "Добро пожаловать, " + Login.Session.CurrentUser.UserName + "!";
            allOrderss = ordersService.getAll();


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

        

        private void ordersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnabled();
        }

        private void ordersBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Session.FormLogin.Visible = true;
        }
    }
}
