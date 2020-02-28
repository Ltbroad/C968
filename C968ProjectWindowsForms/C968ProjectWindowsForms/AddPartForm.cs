using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968ProjectWindowsForms
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.Salmon;
            inventoryTextBox.BackColor = Color.Salmon;
            priceCostTextBox.BackColor = Color.Salmon;
            maxTextBox.BackColor = Color.Salmon;
            minTextBox.BackColor = Color.Salmon;
            machineCompanyTextBox.BackColor = Color.Salmon;

            saveButton.Enabled = false;
            idTextBox.Enabled = false;
        }

        //Changes Machine / Company label text depending on which radio button is checked
        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Company Name";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Convert textbox strings to integers
            Part savePart;
            int partID = Inventory.IncrementPartID;
            int inStock = Int32.Parse(inventoryTextBox.Text);   
            int max = Int32.Parse(maxTextBox.Text);
            int min = Int32.Parse(minTextBox.Text);

            //Try-Catch block to handle exception when converting from string to decimal
            decimal priceException = 0;
            try
            {
                priceException = decimal.Parse(priceCostTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter only values with a decimal in the price text box.");
                return;
            }
            decimal price = decimal.Parse(priceCostTextBox.Text);

            if (inHouseRadioButton.Checked)
            {
                int machineID = Int32.Parse(machineCompanyTextBox.Text);
                savePart = new InHouse(partID, nameTextBox.Text, price, inStock, min, max, machineID);
            }
            else
            {
                string companyName = machineCompanyTextBox.Text;
                savePart = new Outsourced(partID, nameTextBox.Text, price, inStock, min, max, companyName);
            }

            //Validate that the Inventory input is not greater than the maximum or less than the minimum inputs
            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory cannot be less than the minimum or greater than the maximum of in stock items.");
                return;
            }

            Inventory.AddPart(savePart);
            this.Close();         
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Changes color of text box and enables save button once input has been tpyed in textboxes
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                saveButton.Enabled = false;
                nameTextBox.BackColor = Color.Salmon;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White && inventoryTextBox.BackColor == Color.White &&
                priceCostTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White &&
                machineCompanyTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryTextBox.Text))
            {
                saveButton.Enabled = false;
                inventoryTextBox.BackColor = Color.Salmon;
            }
            else
            {
                inventoryTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White && inventoryTextBox.BackColor == Color.White &&
                priceCostTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White &&
                machineCompanyTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void priceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceCostTextBox.Text))
            {
                saveButton.Enabled = false;
                priceCostTextBox.BackColor = Color.Salmon;
            }
            else
            {
                priceCostTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White && inventoryTextBox.BackColor == Color.White &&
                priceCostTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White &&
                machineCompanyTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxTextBox.Text))
            {
                saveButton.Enabled = false;
                maxTextBox.BackColor = Color.Salmon;
            }
            else
            {
                maxTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White && inventoryTextBox.BackColor == Color.White &&
                priceCostTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White &&
                machineCompanyTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minTextBox.Text))
            {
                saveButton.Enabled = false;
                minTextBox.BackColor = Color.Salmon;
            }
            else
            {
                minTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White && inventoryTextBox.BackColor == Color.White &&
                priceCostTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White &&
                machineCompanyTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void machineCompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(machineCompanyTextBox.Text))
            {
                saveButton.Enabled = false;
                machineCompanyTextBox.BackColor = Color.Salmon;
            }
            else
            {
                machineCompanyTextBox.BackColor = Color.White;
            }

            if (nameTextBox.BackColor == Color.White && inventoryTextBox.BackColor == Color.White &&
                priceCostTextBox.BackColor == Color.White &&
                maxTextBox.BackColor == Color.White &&
                minTextBox.BackColor == Color.White &&
                machineCompanyTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }
    }
}

