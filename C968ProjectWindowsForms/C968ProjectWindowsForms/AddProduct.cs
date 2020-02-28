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
    public partial class AddProduct : Form
    {
        Product TempProduct; //Create variable for temporary list
        int prodIDNumber;
        public AddProduct(Product product, int getProduct)
        {
            InitializeComponent();
            idTextBox.Text = getProduct.ToString();
            prodIDNumber = getProduct;
        }

        public AddProduct()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = candidatePartsDataGrid.SelectedRows[0];
            int partID = Convert.ToInt32(selected.Cells["PartID"].Value);
            Part part = Inventory.LookupPart(partID);
            TempProduct.AddAssociatedPart(part);

            associatedPartsDataGrid.DataSource = TempProduct.AssociatedParts; //Associated datagrid pulls from the temporary list
        }

        //Delete row from lower datagridview
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = associatedPartsDataGrid.SelectedRows[0];
            int partID = Convert.ToInt32(selected.Cells["PartID"].Value);
            Part part = Inventory.LookupProduct(prodIDNumber).LookupAssociatedPart(partID);
            TempProduct.RemoveAssociatedPart(partID);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            decimal priceException = 0;

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

            int ProductID = Inventory.IncrementProductID;
            TempProduct.Name = nameTextBox.Text;
            TempProduct.Price = Convert.ToDecimal(priceCostTextBox.Text);
            TempProduct.InStock = Convert.ToInt32(inventoryTextBox.Text);
            TempProduct.Min = Convert.ToInt32(minTextBox.Text);
            TempProduct.Max = Convert.ToInt32(maxTextBox.Text);

            Inventory.AddProduct(TempProduct);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Search Parts list by name and show message if a part is not found
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
                minTextBox.BackColor == Color.White)
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
                minTextBox.BackColor == Color.White)
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
                minTextBox.BackColor == Color.White)
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
                minTextBox.BackColor == Color.White)
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
                minTextBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            TempProduct = new Product(); //Create instance of temporary list when form loads

            candidatePartsDataGrid.DataSource = Inventory.AllParts;
            candidatePartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            associatedPartsDataGrid.DataSource = Inventory.LookupProduct(prodIDNumber).AssociatedParts;
            associatedPartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            nameTextBox.BackColor = Color.Salmon;
            inventoryTextBox.BackColor = Color.Salmon;
            priceCostTextBox.BackColor = Color.Salmon;
            maxTextBox.BackColor = Color.Salmon;
            minTextBox.BackColor = Color.Salmon;

            saveButton.Enabled = false;
            idTextBox.Enabled = false;
        }

        private void candidatePartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPart = e.RowIndex;
        }

        private void associatedPartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
