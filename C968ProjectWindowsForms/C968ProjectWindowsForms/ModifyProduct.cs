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
    public partial class ModifyProduct : Form
    {
        public int productIDNumber;

        public ModifyProduct(int loadProduct)
        {
            InitializeComponent();

            idTextBox.Text = loadProduct.ToString();
            productIDNumber = loadProduct;
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = Inventory.LookupProduct(productIDNumber).Name;
            inventoryTextBox.Text = Inventory.LookupProduct(productIDNumber).InStock.ToString();
            priceCostTextBox.Text = Inventory.LookupProduct(productIDNumber).Price.ToString();
            maxTextBox.Text = Inventory.LookupProduct(productIDNumber).Max.ToString();
            minTextBox.Text = Inventory.LookupProduct(productIDNumber).Min.ToString();

            candidatePartsDataGrid.DataSource = Inventory.AllParts;
            candidatePartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            associatedPartsDataGrid.DataSource = Inventory.LookupProduct(productIDNumber).AssociatedParts;
            associatedPartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            idTextBox.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int partID = Inventory.CurrentPart;
            Part part = Inventory.LookupPart(partID);
            Inventory.LookupProduct(productIDNumber).AddAssociatedPart(part);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = associatedPartsDataGrid.SelectedRows[0];
            int partID = Convert.ToInt32(selected.Cells["PartID"].Value);
            Part part = Inventory.LookupProduct(productIDNumber).LookupAssociatedPart(partID);
            Inventory.LookupProduct(productIDNumber).RemoveAssociatedPart(partID);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            decimal priceException = 0;
            Product productUpdate;

            //Handle exception if decimal number is not input in Price textbox
            try
            {
                priceException = decimal.Parse(priceCostTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter only values with a decimal in the price text box.");
                return;
            }

            //Show error message if inventory text is greater than max stock or less than minimum stock
            if (Convert.ToInt32(inventoryTextBox.Text) < Convert.ToInt32(minTextBox.Text) || Convert.ToInt32(inventoryTextBox.Text) > Convert.ToInt32(maxTextBox.Text))
            {
                MessageBox.Show("Inventory cannot be less than the minimum or greater than the maximum of in stock items.");
                return;
            }
            
            productUpdate = new Product(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, Convert.ToDecimal(priceCostTextBox.Text), Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));

            foreach (Part associatedPart in Inventory.LookupProduct(productIDNumber).AssociatedParts)
            {
                productUpdate.AddAssociatedPart(associatedPart);
            }
            Inventory.UpdateProduct(Convert.ToInt32(idTextBox.Text), productUpdate);
            this.Close();           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search by Part name
        private void searchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TemporaryList = new BindingList<Part>();
            bool foundPart = false;
            if (searchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchTextBox.Text.ToUpper()))
                    {
                        TemporaryList.Add(Inventory.AllParts[i]);
                        foundPart = true;
                    }
                }
                if (foundPart)
                    candidatePartsDataGrid.DataSource = TemporaryList;
            }
            if (!foundPart)
            {
                MessageBox.Show("Part not found.");
                candidatePartsDataGrid.DataSource = Inventory.AllParts;
            }
        }

        private void candidatePartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPart = e.RowIndex; // Remember data in row selected
        }

        private void associatedPartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
