using C968ProjectWindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968ProjectWindowsForms
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        //Set properties for remembering what is selected in the datagridviews
        public static int CurrentProduct { get; set; }
        public static int CurrentPart { get; set; }

        //Increment PartID and ProductID everytime one is created
        public static int IncrementPartID { get; set; }
        public static int IncrementProductID { get; set; }
        public Inventory()
        {
            IncrementPartID = 0;
            IncrementProductID = 0;
        }

        public static void AddProduct(Product product)
        {
            product.ProductID = IncrementProductID;
            IncrementProductID++;
            Products.Add(product);
        }

        public static bool RemoveProduct(int productID)
        {
            Products.RemoveAt(CurrentProduct);
            return false;
        }

        public static Product LookupProduct(int productID)
        {
            Product prod = new Product();
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return prod;
        }

        public static void UpdateProduct(int productID, Product product)
        {
            product.AssociatedParts = LookupProduct(productID).AssociatedParts;
            RemoveProduct(productID);
            AddProduct(product);
        }

        public static void AddPart(Part part)
        {
            part.PartID = IncrementPartID;
            IncrementPartID++;
            AllParts.Add(part);
        }

        public static bool DeletePart(int partID)
        {
            AllParts.RemoveAt(CurrentPart);
            return true;
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part noPart = null;
            return noPart;
        }

        public static void UpdatePart(int partID, Part part)
        {
            LookupPart(partID);
            DeletePart(partID);
            AddPart(part);
        }
    }
}
