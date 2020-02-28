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
    public partial class ModifyPart : Form
    {
        public int selectedPartID;
        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(int loadPart)
        {
            InitializeComponent();
            idTextBox.Text = loadPart.ToString();
            selectedPartID = loadPart;

            nameTextBox.Text = Inventory.LookupPart(selectedPartID).Name;
            inventoryTextBox.Text = Inventory.LookupPart(selectedPartID).InStock.ToString();
            priceCostTextBox.Text = Inventory.LookupPart(selectedPartID).Price.ToString();
            maxTextBox.Text = Inventory.LookupPart(selectedPartID).Max.ToString();
            minTextBox.Text = Inventory.LookupPart(selectedPartID).Min.ToString();


            if (Inventory.LookupPart(selectedPartID).isOutsourced)
            {
                outsourcedRadioButton.Checked = true;
                machineCompanyTextBox.Text = Inventory.LookupPart(selectedPartID).CompanyName;
            }
            else
            {
                inHouseRadioButton.Checked = true;
                machineCompanyTextBox.Text = Inventory.LookupPart(selectedPartID).MachineID.ToString();
            }            
        }

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
            Part partUpdate;
            int partID = Int32.Parse(idTextBox.Text);
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
                partUpdate = new InHouse(partID, nameTextBox.Text, price, inStock, min, max, machineID);
            }
            else
            {
                string companyName = machineCompanyTextBox.Text;
                partUpdate = new Outsourced(partID, nameTextBox.Text, price, inStock, min, max, companyName);
            }

            //Validate that the Inventory input is not greater than the maximum or less than the minimum inputs
            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory cannot be less than the minimum or greater than the maximum of in stock items.");
                return;
            }

            Inventory.UpdatePart(Convert.ToInt32(idTextBox.Text), partUpdate);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            idTextBox.Enabled = false;
        }
    }
}
