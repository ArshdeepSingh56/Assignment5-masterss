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
    public partial class SelectForm : Form
    {
        // Declare private member
        private DollarComputersEntity _entity;
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get all products from database and load into
        /// data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // Create new DollarComputersEntity object
            using (_entity = new DollarComputersEntity())
            {
                // Using LINQ get all products
                var query = from p in _entity.Products
                            select p;
                
                // Display products
                ProductDataGridView.DataSource = query.ToList<Product>();
            }

        }

        /// <summary>
        /// On DataGridView cell click determine user clicked on a
        /// valid cell and then select that corresponding whole row
        /// Call method GetDataFromSelectedRow() to get the select
        /// Product from the row and display the info in textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductDataGridView.Rows[e.RowIndex].Selected = true;

                GetDataFromSelectedRow();
                NextButton.Enabled = true;  //make next button enabled
            }
            else
            {
                NextButton.Enabled = false;
            }
        }

        /// <summary>
        /// Get the Product object from the selected row
        /// and initialize Program.selectedProduct
        /// determine selectedProduct is not null
        /// Display the short info
        /// </summary>
        private void GetDataFromSelectedRow()
        {
            Program.selectedProduct = (Product)ProductDataGridView.CurrentRow.DataBoundItem;

            if(Program.selectedProduct != null)
            {
                string manufacturer = Program.selectedProduct.manufacturer;
                string model = Program.selectedProduct.model;
                decimal cost = (decimal)Program.selectedProduct.cost;

                ProductInfoTextBox.Text = manufacturer + " " + model + " Priced at: " + cost.ToString("C2");
            }
        }

        /// <summary>
        /// Hide this this form and open product info form
        /// to display the selected product in details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.ShowDialog();
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
