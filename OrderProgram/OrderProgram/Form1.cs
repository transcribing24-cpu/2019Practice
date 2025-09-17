using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int quantity = 0;
        double subTot = 0;
        double total = 0;

        private void ProcessOrderClick(object sender, EventArgs e)
        {

        }

        private void DisplayorderClick(object sender, EventArgs e)
        {
            total += subTot + 0.14 * subTot;

            label5.Text = $"Total incl. VAT 14%: R{total}";
        }

        private void ExitAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("First select the size of jersey that you need.\n\n Select the quantity of Jerseys you need. To add jerseys, click on the plus button." +
                "To decrease the number of jersey, click on the minus button. The quantity of Jerseys chosen will be displayed above the buttons. Make sure the " +
                "quantity is greater than zero.\n\nClick on the green Add to Cart button to add the item to the cart.\n\n" +
                "The total displayed at the bottom exludes the 14% VAT.\n\nTo display your Cart plus the total owed with VAT, under Process, click on Display Order.");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SubQuantClik(object sender, EventArgs e)
        {
            quantity -= 1;

            label3.Text = $"{quantity}";
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            quantity += 1;
            label3.Text = $"{quantity}";

        }

        private void AddToCartClick(object sender, EventArgs e)
        {
            string selSize = comboBox1.SelectedItem.ToString();

            if(quantity > 1)
            {
                listBox1.Items.Add($"{quantity} {selSize} Jerseys");
            }
            else if(quantity == 1)
            {
                listBox1.Items.Add($"{quantity} {selSize} Jersey");
            }
            else
            {
                MessageBox.Show("Please select a valid quantity of jerseys. Quantity selected must be greater than or equal 1");
                return;
            }


            if(selSize == "XSmall" || selSize == "XXLarge")
            {
                subTot += quantity * 20;
            }

            subTot += quantity * 16;

            label4.Text = $"Subtotal: R{subTot}";


        }
    }
}
