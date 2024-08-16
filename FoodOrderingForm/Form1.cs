using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodOrderingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeItemPrices();
        }
        Dictionary<CheckBox, int> itemPrices;
        private void InitializeItemPrices()
        {
            itemPrices = new Dictionary<CheckBox, int>
            {
                { ckbChicken, 50 },
                { ckbBeef, 60 },
                { ckbPork, 80 },
                { ckbCoke, 10 },
                { ckbSprite, 10 },
                { ckbRoyal, 10 },
                { ckbSpicy, 15 },
                { ckbSweetSpicy, 20 },
                { ckbRegular, 10 }
            };

            ckbChicken.CheckedChanged += CheckedChanged;
            ckbBeef.CheckedChanged += CheckedChanged;
            ckbPork.CheckedChanged += CheckedChanged;
            ckbCoke.CheckedChanged += CheckedChanged;
            ckbSprite.CheckedChanged += CheckedChanged;
            ckbRoyal.CheckedChanged += CheckedChanged;
            ckbSpicy.CheckedChanged += CheckedChanged;
            ckbSweetSpicy.CheckedChanged += CheckedChanged;
            ckbRegular.CheckedChanged += CheckedChanged;
        }



        string orders = string.Empty;
        int result = 0, total = 0;
        string dine = string.Empty;

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                result += itemPrices[checkbox] ;
                total += itemPrices[checkbox] ;
                orders += $"P{itemPrices[checkbox]} - {checkbox.Text} \n";
                lstBox.Items.Add($"{checkbox.Text} \n");
            }
            else
            {
                result -= itemPrices[checkbox];
                total -= itemPrices[checkbox];
                orders = orders.Replace($"P{itemPrices[checkbox]} - {checkbox.Text} \n", "");
                for (int i = lstBox.Items.Count - 1; i >= 0; i--)
                {
                    if (lstBox.Items[i].ToString().Trim() == checkbox.Text)
                    {
                        lstBox.Items.RemoveAt(i);
                    }
                }
            }
            lblResult.Text = "₱" + result.ToString();
        }

        private void radTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radTakeOut.Checked)
            {
                dine = "Take out";
            }
        }

        private void radDineIn_CheckedChanged(object sender, EventArgs e)
        {
            if (radDineIn.Checked)
            {
                dine = "Dine In";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            orders = String.Empty;
            lblResult.Text = "₱0";
            txtName.Text = String.Empty;
            cmbPaymentMethod.Text = null;
            radDineIn.Checked = false;
            radTakeOut.Checked = false;
            ckbBeef.Checked = false;
            ckbChicken.Checked = false;
            ckbPork.Checked = false;
            ckbCoke.Checked = false;
            ckbSprite.Checked = false;
            ckbRoyal.Checked = false;
            ckbSpicy.Checked = false;
            ckbSweetSpicy.Checked = false;
            ckbRegular.Checked = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            try
            {
                bool anyChecked = itemPrices.Any(pair => pair.Key.Checked);

                if (!anyChecked)
                {
                    throw new Exception("Please select at least one item.");
                }

                if (string.IsNullOrEmpty(txtName.Text) || cmbPaymentMethod.SelectedIndex == -1 || (radDineIn.Checked == false && radTakeOut.Checked == false))
                {
                    throw new Exception("Please fill out all the necessary data to process your order.");
                }


                DateTime currentDateTime = DateTime.Now; 
                string receipt = $"WONDERFUL BURGERS INC.\nAddress: 7WR4+X7J, A. Pigafetta Street, Cebu City, 6000 Cebu \nDate: {currentDateTime} \n\n" +
                    $"Hi {txtName.Text}!" +
                    $"\nOrder Details:\n\nPayment Method: {cmbPaymentMethod.SelectedItem} \nDine: {dine} \nOrders: \n{orders} \nTotal: P{total}.";
                string message = "RECEIPT";

                DialogResult resultDialog = MessageBox.Show(receipt, message, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultDialog == DialogResult.OK)
                {
                    btnClear_Click(sender, e); 
                }
            }
            catch (Exception ex)
            {
                string error = $"Error: {ex.Message} \n \nThank you!";
                string message = "Error";

                MessageBox.Show(error, message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    } 
 }