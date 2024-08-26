using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaMenu
{
    public partial class pizzaMenu : Form
    {
        public pizzaMenu()
        {
            InitializeComponent();
        }

        double small, medium, large;
        double smallPrice, mediumPrice, largePrice;

        double delivery, coupon;

        int items;
        double totalPrice;

        private void pizzaMenu_Load(object sender, EventArgs e)
        {

            rdoSmall.Checked = true;
            rdoItem1.Checked = true;

            small = 150;
            medium = 200;
            large = 350;

            smallPrice = 50;
            mediumPrice = 70;
            largePrice = 100;

            delivery = 60;
            coupon = 50;

            items = 1;
            totalPrice = 0;

        }


        private void rdoItem1_CheckedChanged(object sender, EventArgs e)
        {
            items = 1;
        }

 
        private void rdoItem3_CheckedChanged(object sender, EventArgs e)
        {
            items = 2;
        }

        private void rdoItem4_CheckedChanged(object sender, EventArgs e)
        {
            items = 3;
        }

        private void rdoItemDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            items = 4;
        }

        private void rdoItem2_CheckedChanged(object sender, EventArgs e)
        {
            items = 6;
        }


        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            items = 1;

            rdoSmall.Checked = true;
            rdoMedium.Checked = false;
            rdoLarge.Checked = false;

            rdoItem1.Checked = true;
            rdoItem2.Checked = false;
            rdoItem3.Checked = false;
            rdoItem4.Checked = false;
            rdoItemDeluxe.Checked = false;

            chkBoxDelivery.Checked = false;
            chkBoxCoupon.Checked = false;

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdoSmall.Checked == true)
            {
                totalPrice = small + smallPrice * items;
            }
            else if(rdoMedium.Checked == true)
            {
                totalPrice = medium + mediumPrice * items;

            }
            else if(rdoLarge.Checked == true)
            {
                totalPrice = large + largePrice * items;
            }

            if(chkBoxDelivery.Checked == true)
            {
                totalPrice += delivery;
            }
            if(chkBoxCoupon.Checked == true)
            {
                totalPrice += coupon;
            }

            lblTotal.Text = totalPrice.ToString("c");
        }

    }
}
