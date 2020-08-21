using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open file dialog and load product info from selected file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenMenu_Click(object sender, EventArgs e)
        {
            // Read and initialize new selectedProduct from file
            LoadProductFromFile();

            // Load product details if not null
            if(Program.selectedProduct != null)
            {
                LoadProductInformation();
                NextButton.Enabled = true;  //make next button enabled
            }
            else
            {
                NextButton.Enabled = false;
            }
        }

        /// <summary>
        /// Save selectedProduct details into user selected/created file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ProductInfoSaveFileDialog.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    if (Program.selectedProduct != null)
                    {
                        StreamWriter streamWriter = new StreamWriter(ProductInfoSaveFileDialog.FileName);

                        // Write product details by using ToString method
                        streamWriter.WriteLine(Program.selectedProduct.ToString());

                        streamWriter.Flush();
                        streamWriter.Close();

                        MessageBox.Show("Product Information Saved.", "Information!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No product found to save.", "Information!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to Save Data!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open select form to select another product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProduct(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        /// <summary>
        /// Set initial directory for both open and save file dialog
        /// if selectedProduct is null then give option to load
        /// product from file.
        /// After selectedProduct load display product info details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            if(Program.selectedProduct == null)
            {
                LoadProductFromFile();
            }
            
            if (Program.selectedProduct != null)
            {
                LoadProductInformation();
                NextButton.Enabled = true;
            }
            else
            {
                NextButton.Enabled = false;
            }
        }

        /// <summary>
        /// Display product information
        /// </summary>
        private void LoadProductInformation()
        {
            if(Program.selectedProduct != null)
            {
                ProductIdTextBox.Text = Program.selectedProduct.productID.ToString();
                ConditionTextBox.Text = Program.selectedProduct.condition;
                CostTextBox.Text = ((decimal)Program.selectedProduct.cost).ToString("C2");

                PlatformTextBox.Text = Program.selectedProduct.platform;
                ManufacturerTextBox.Text = Program.selectedProduct.manufacturer;
                OSTextBox.Text = Program.selectedProduct.OS;
                ModelTextBox.Text = Program.selectedProduct.model;

                MemoryTextBox.Text = Program.selectedProduct.RAM_size;
                CpuBrandTextBox.Text = Program.selectedProduct.CPU_brand;
                CpuTypeTextBox.Text = Program.selectedProduct.CPU_type;
                LcdSizeTextBox.Text = Program.selectedProduct.screensize;
                CpuNumberTextBox.Text = Program.selectedProduct.CPU_number;
                CpuSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
                HddTextBox.Text = Program.selectedProduct.HDD_size;
                GpuTypeTextBox.Text = Program.selectedProduct.GPU_Type;
                WebCamTextBox.Text = Program.selectedProduct.webcam;
            }
        }

        /// <summary>
        /// Load saved product data from user selected file
        /// read selected file and generate new selectedProduct object
        /// with all required fileds.
        /// </summary>
        private void LoadProductFromFile()
        {
            try
            {
                var result = ProductInfoOpenFileDialog.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    StreamReader streamReader = new StreamReader(ProductInfoOpenFileDialog.FileName);

                    string line = streamReader.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] data = line.Split(',');

                        if (data.Length == 16)
                        {
                            Program.selectedProduct = new Product();
                            Program.selectedProduct.productID = Convert.ToInt16(data[0]);
                            Program.selectedProduct.condition = data[1];
                            Program.selectedProduct.cost = Convert.ToDecimal(data[2]);

                            Program.selectedProduct.platform = data[3];
                            Program.selectedProduct.OS = data[4];
                            Program.selectedProduct.manufacturer = data[5];
                            Program.selectedProduct.model = data[6];

                            Program.selectedProduct.RAM_size = data[7];
                            Program.selectedProduct.screensize = data[8];
                            Program.selectedProduct.HDD_size = data[9];
                            Program.selectedProduct.CPU_brand = data[10];
                            Program.selectedProduct.CPU_number = data[11];
                            Program.selectedProduct.GPU_Type = data[12];
                            Program.selectedProduct.CPU_type = data[13];
                            Program.selectedProduct.CPU_speed = data[14];
                            Program.selectedProduct.webcam = data[15];
                        }
                    }

                    streamReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to Load Data!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        /// Open order from to complete the order process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.ShowDialog();
        }

        private void ProductInfoMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
