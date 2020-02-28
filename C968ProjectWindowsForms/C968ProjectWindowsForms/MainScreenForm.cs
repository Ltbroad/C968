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
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();

            // Prepopulate datagrids and set the source of the grids to the lists
            Inventory.AllParts.Add(new InHouse(Inventory.IncrementPartID, "Wheel", 12.11M, 15, 5, 25));
            Inventory.IncrementPartID++;
            Inventory.AllParts.Add(new InHouse(Inventory.IncrementPartID, "Pedal", 8.22M, 11, 5, 25));
            Inventory.IncrementPartID++;
            Inventory.AllParts.Add(new InHouse(Inventory.IncrementPartID, "Chain", 8.33M, 12, 5, 25));
            Inventory.IncrementPartID++;
            Inventory.AllParts.Add(new Outsourced(Inventory.IncrementPartID, "Seat", 4.55M, 8, 2, 15));
            Inventory.IncrementPartID++;


            partsDataGridView.DataSource = Inventory.AllParts;
            partsDataGridView.Columns["machineID"].Visible = false;
            partsDataGridView.Columns["companyName"].Visible = false;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            Inventory.Products.Add(new Product(Inventory.IncrementProductID, "Red Bicycle", 11.44M, 15, 1, 25));
            Inventory.IncrementProductID++;
            Inventory.Products.Add(new Product(Inventory.IncrementProductID, "Yellow Bicycle", 9.66M, 19, 1, 20));
            Inventory.IncrementProductID++;
            Inventory.Products.Add(new Product(Inventory.IncrementProductID, "Blue Bicycle", 12.77M, 5, 1, 25));
            Inventory.IncrementProductID++;


            productsDataGridView.DataSource = Inventory.Products;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPartButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddPartForm showAddPartForm = new AddPartForm();
            showAddPartForm.ShowDialog();
            this.Show();
        }

        private void modifyPartButton_Click_1(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = partsDataGridView.SelectedRows[0];
            int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
            Part part = Inventory.LookupPart(partID);
            ModifyPart partModify = new ModifyPart(partID);
            this.Hide();
            partModify.ShowDialog();
            this.Show();
        }

        private void deletePartButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?",
                "Confirm delete.", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = partsDataGridView.SelectedRows[0];
                int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Part partDelete = Inventory.LookupPart(partID);
                Inventory.DeletePart(Inventory.CurrentPart);
                RefreshBinding();
            }
            else
            {
                return;
            }
        }

        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct showAddProductForm = new AddProduct();
            showAddProductForm.ShowDialog();
            this.Show();
        }

        private void modifyProductButton_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = productsDataGridView.SelectedRows[0];
            int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
            Product product = Inventory.LookupProduct(productID);
            ModifyProduct productModify = new ModifyProduct(productID);
            this.Hide();
            productModify.ShowDialog();
            this.Show();
        }   

        private void deleteProductButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?",
            "Confirm delete.", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = productsDataGridView.SelectedRows[0];
                int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                Product productDelete = Inventory.LookupProduct(productID);
                if (productDelete.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Unable to delete a Product with a part associated to it.");
                    return;
                }
                Inventory.RemoveProduct(Inventory.CurrentProduct);
                RefreshBinding();
            }
            else
            {
                return;
            }
        }

        // Search parts by name
        private void searchPartsButton_Click_1(object sender, EventArgs e)
        {
            BindingList<Part> TemporaryList = new BindingList<Part>();
            bool foundPart = false;
            if (searchPartsTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchPartsTextBox.Text.ToUpper()))
                    {
                        TemporaryList.Add(Inventory.AllParts[i]);
                        foundPart = true;
                    }
                }
                if (foundPart)
                    partsDataGridView.DataSource = TemporaryList;
            }
            if (!foundPart)
            {
                MessageBox.Show("Part not found.");
                partsDataGridView.DataSource = Inventory.AllParts;
            }
        }

        // Search products by name
        private void searchProductsButton_Click_1(object sender, EventArgs e)
        {
            BindingList<Product> ListTemporary = new BindingList<Product>();
            bool foundProduct = false;
            if (searchProductsTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(searchProductsTextBox.Text.ToUpper()))
                    {
                        ListTemporary.Add(Inventory.Products[i]);
                        foundProduct = true;
                    }
                }
                if (foundProduct)
                    productsDataGridView.DataSource = ListTemporary;
            }
            if (!foundProduct)
            {
                MessageBox.Show("Part not found.");
                productsDataGridView.DataSource = Inventory.Products;
            }
        }

        private void RefreshBinding()
        {
            productsDataGridView.DataSource = Inventory.Products;
            partsDataGridView.DataSource = Inventory.AllParts;
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentProduct = e.RowIndex; //Remember data that is selected in the current row
        }

        private void partsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPart = e.RowIndex;
        }
    }
}
