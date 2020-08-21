using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class OrderForm : Form
    {
        // Declare constant to hold 13% sales tax
        const decimal TAX = 0.13M;
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load product information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            if(Program.selectedProduct != null)
            {
                ConditionTextBox.Text = Program.selectedProduct.condition;
                PlatformTextBox.Text = Program.selectedProduct.platform;
                ManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
                ModelTextBox.Text = Program.selectedProduct.model;
                TechSpecsTextBox.AppendText(Program.selectedProduct.screensize + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.RAM_size + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.CPU_brand + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.CPU_type + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.CPU_number + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.CPU_speed + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.HDD_size + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.GPU_Type + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.webcam + Environment.NewLine + Environment.NewLine);
                TechSpecsTextBox.AppendText(Program.selectedProduct.OS);

                // Calculate tax and total cost before display
                //cost could be null, that's why using null-coalescing operator
                //if null then cost will be zero
                decimal cost = Program.selectedProduct.cost ?? 0;
                decimal tax = (cost * TAX);
                PriceTextBox.Text = cost.ToString("C2");
                SalesTaxTextBox.Text = tax.ToString("C2");
                TotalTextBox.Text = (cost + tax).ToString("C2");
            }
        }

        /// <summary>
        /// Back to product info form if user want's to change or check the product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToProductInfoForm(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Display a message box with meaningful text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order invoice is printing...", "Information!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Display about box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutMenu_Click(object sender, EventArgs e)
        {
            DollarComputersAboutBox aboutBox = new DollarComputersAboutBox();
            aboutBox.Show();
        }

        /// <summary>
        /// Display a message box with meaningful text and exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            string msg = "Thank you for business with us!\nYour order will be processed in 7-10 business days.";

            MessageBox.Show(msg, "Information!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }
    }
}
