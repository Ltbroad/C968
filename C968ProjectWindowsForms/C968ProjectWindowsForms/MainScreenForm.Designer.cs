namespace C968ProjectWindowsForms
{
    partial class MainScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inventoryManagementSystemLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchPartsTextBox = new System.Windows.Forms.TextBox();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchProductsTextBox = new System.Windows.Forms.TextBox();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainScreenFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryManagementSystemLabel
            // 
            this.inventoryManagementSystemLabel.AutoSize = true;
            this.inventoryManagementSystemLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryManagementSystemLabel.Location = new System.Drawing.Point(1, 9);
            this.inventoryManagementSystemLabel.Name = "inventoryManagementSystemLabel";
            this.inventoryManagementSystemLabel.Size = new System.Drawing.Size(215, 16);
            this.inventoryManagementSystemLabel.TabIndex = 0;
            this.inventoryManagementSystemLabel.Text = "Inventory Management System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchPartsTextBox);
            this.groupBox1.Controls.Add(this.searchPartsButton);
            this.groupBox1.Controls.Add(this.deletePartButton);
            this.groupBox1.Controls.Add(this.modifyPartButton);
            this.groupBox1.Controls.Add(this.addPartButton);
            this.groupBox1.Controls.Add(this.partsDataGridView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 231);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // searchPartsTextBox
            // 
            this.searchPartsTextBox.Location = new System.Drawing.Point(261, 15);
            this.searchPartsTextBox.Name = "searchPartsTextBox";
            this.searchPartsTextBox.Size = new System.Drawing.Size(144, 20);
            this.searchPartsTextBox.TabIndex = 19;
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.searchPartsButton.FlatAppearance.BorderSize = 3;
            this.searchPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchPartsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchPartsButton.Location = new System.Drawing.Point(191, 15);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(64, 20);
            this.searchPartsButton.TabIndex = 18;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            this.searchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click_1);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(353, 200);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(52, 23);
            this.deletePartButton.TabIndex = 17;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click_1);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(287, 200);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(60, 23);
            this.modifyPartButton.TabIndex = 16;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click_1);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(227, 200);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(54, 23);
            this.addPartButton.TabIndex = 15;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click_1);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToDeleteRows = false;
            this.partsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(21, 44);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.Size = new System.Drawing.Size(384, 150);
            this.partsDataGridView.TabIndex = 14;
            this.partsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchProductsTextBox);
            this.groupBox2.Controls.Add(this.searchProductsButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.deleteProductButton);
            this.groupBox2.Controls.Add(this.modifyProductButton);
            this.groupBox2.Controls.Add(this.addProductButton);
            this.groupBox2.Controls.Add(this.productsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(457, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 231);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // searchProductsTextBox
            // 
            this.searchProductsTextBox.Location = new System.Drawing.Point(268, 19);
            this.searchProductsTextBox.Name = "searchProductsTextBox";
            this.searchProductsTextBox.Size = new System.Drawing.Size(158, 20);
            this.searchProductsTextBox.TabIndex = 21;
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.searchProductsButton.FlatAppearance.BorderSize = 3;
            this.searchProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchProductsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchProductsButton.Location = new System.Drawing.Point(198, 19);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(64, 20);
            this.searchProductsButton.TabIndex = 20;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Products";
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(375, 201);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(52, 23);
            this.deleteProductButton.TabIndex = 18;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click_1);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(309, 201);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(60, 23);
            this.modifyProductButton.TabIndex = 17;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click_1);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(249, 201);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(54, 23);
            this.addProductButton.TabIndex = 16;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click_1);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(13, 45);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(413, 150);
            this.productsDataGridView.TabIndex = 15;
            this.productsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(833, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 33);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainScreenFormBindingSource
            // 
            this.mainScreenFormBindingSource.DataSource = typeof(C968ProjectWindowsForms.MainScreenForm);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(930, 360);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inventoryManagementSystemLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryManagementSystemLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchPartsTextBox;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchProductsTextBox;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.BindingSource mainScreenFormBindingSource;
    }
}

