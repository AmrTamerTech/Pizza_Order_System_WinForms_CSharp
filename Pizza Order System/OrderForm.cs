using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp55_Pizza_Project
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        float GetSizePrice()
        {
            if (rdoSmall.Checked) return Convert.ToSingle(rdoSmall.Tag);
            else if (rdoMedium.Checked) return Convert.ToSingle(rdoMedium.Tag);
            else if (rdoLarge.Checked) return Convert.ToSingle(rdoLarge.Tag);
            else return 0;
        }
        float GetCrustTypePrice()
        {
            if (rdoThin.Checked) return Convert.ToSingle(rdoThin.Tag);
            else if (rdoThick.Checked) return Convert.ToSingle(rdoThick.Tag);
            else return 0;
        }
        float GetToppingPrice()
        {
            float Price = 0;
            if (chkExtraCheese.Checked) Price += Convert.ToSingle(chkExtraCheese.Tag);
            if (chkGreenPeppers.Checked) Price += Convert.ToSingle(chkGreenPeppers.Tag);
            if (chkMushroom.Checked) Price += Convert.ToSingle(chkMushroom.Tag);
            if (chkOlives.Checked) Price += Convert.ToSingle(chkOlives.Tag);
            if (chkTomatoes.Checked) Price += Convert.ToSingle(chkTomatoes.Tag);
            if (chkOnion.Checked) Price += Convert.ToSingle(chkOnion.Tag);
            return Price;
        }
        float CalculateTotalPrice()
        {
            return GetSizePrice() + GetCrustTypePrice() + GetToppingPrice();
        }
        void UpdateTotalPrice()
        {
            lblTotal.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rdoSmall.Checked) lblSize.Text = "Small Size";
            else if (rdoMedium.Checked) lblSize.Text = "Medium Size";
            else if (rdoLarge.Checked) lblSize.Text = "Large Size";
            else lblSize.Text = "Not Selected";
        }
        void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rdoThin.Checked) lblCrust.Text = "Thin Crust";
            else if (rdoThick.Checked) lblCrust.Text = "Thick Crust";
            else lblCrust.Text = "Not Selected";
        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if (rdoEatIn.Checked) lblWhereToEat.Text = "Eat In";
            else if (rdoTakeOut.Checked) lblWhereToEat.Text = "Take Out";
            else lblWhereToEat.Text = "Not Selected";
        }
        void UpdateTopping()
        {
            UpdateTotalPrice();
            string Topping = "";
            if (chkExtraCheese.Checked) Topping += "ExtraCheese";
            if (chkGreenPeppers.Checked) Topping += ",GreenPeppers";
            if (chkMushroom.Checked) Topping += ",Mushrooms";
            if (chkOlives.Checked) Topping += ",Olives";
            if (chkTomatoes.Checked) Topping += ",Tomatoes";
            if (chkOnion.Checked) Topping += ",Onion";

            if (string.IsNullOrEmpty(Topping))
            {
                lblTopping.Text = "Not Selected";
                return;
            }
            if (Topping.StartsWith(","))
            {
                Topping = Topping.Substring(1, Topping.Length - 1).Trim();
            }
            lblTopping.Text = Topping;
        }
        void UpdateOrder()
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbTopping.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
                StringBuilder receipt = new StringBuilder();
                receipt.AppendLine("Amr’s Pizzeria");
                receipt.AppendLine("---------------------------------------------------------------------------------");
                receipt.AppendLine("Size: " + lblSize.Text);
                receipt.AppendLine("Crust Type: " + lblCrust.Text);
                receipt.AppendLine("Topping: " + lblTopping.Text);
                receipt.AppendLine("Where To Eat: " + lblWhereToEat.Text);
                receipt.AppendLine("---------------------------------------------------------------------------------");
                receipt.AppendLine("Total: " + lblTotal.Text);
                receipt.AppendLine("---------------------------------------------------------------------------------");
                MessageBox.Show(receipt.ToString(), "Success");
            }
        }
        void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbTopping.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;
            //Size
            rdoSmall.Checked = false;
            rdoMedium.Checked = false;
            rdoLarge.Checked = false;

            //Crust
            rdoThin.Checked = false;
            rdoThick.Checked = false;

            //Topping
            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            chkMushroom.Checked = false;

            //Where To Eat
            rdoEatIn.Checked = false;
            rdoTakeOut.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }
        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }
        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rdoTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void chkTopping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateOrder();
        }
    }
}
