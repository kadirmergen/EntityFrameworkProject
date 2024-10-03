using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class UrunForm : Form
    {
        ProjectsDBEntities entities = new ProjectsDBEntities();

        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            ShowAllRecords();
            textBoxProductId.Text = "0";
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            ShowAllRecords();
        }

        private void ShowAllRecords()
        {
            //var product = entities.Products.ToList();
            var products = (from product in entities.Products select new
            {
                product.ProductId,
                product.ProductName,
                product.Price
            }).ToList();
            dataGridView1.DataSource = products;
            dataGridView1.ClearSelection();
            ClearTextBox();
            labelNumberofProduct.Text = entities.Products.Count().ToString();
        }

        private void ClearTextBox()
        {
            textBoxProductId.Text = "0";
            textBoxName.Clear();
            textBoxPrice.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                Products product = new Products();
                product.ProductName = textBoxName.Text;
                product.Price = Convert.ToInt32(textBoxPrice.Text);
                try
                {
                    entities.Products.Add(product);
                    entities.SaveChanges();
                    MessageBox.Show("Product added!");
                    ShowAllRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Products can not added.\n" + ex.Message);
                }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var choosenProduct = dataGridView1.SelectedCells[0].RowIndex;
            textBoxProductId.Text = dataGridView1.Rows[choosenProduct].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[choosenProduct].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridView1.Rows[choosenProduct].Cells[2].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductId.Text) || textBoxProductId.Text.Equals("0"))
            {
                MessageBox.Show("Please select a product.");
            }
            else
            {
                try
                {
                    int productId = Convert.ToInt32(textBoxProductId.Text);
                    var product = entities.Products.Find(productId);
                    if (product != null)
                    {
                        entities.Products.Remove(product);
                        entities.SaveChanges();
                        MessageBox.Show("Product removed!");
                        ShowAllRecords();
                    }
                    else
                    {
                        MessageBox.Show("Product cannot found on database");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection occured with an error\n" + ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(textBoxProductId.Text);
                var product = entities.Products.Find(productId);
                if(product != null)
                {
                    product.ProductName = textBoxName.Text;
                    product.Price = Convert.ToInt32(textBoxPrice.Text);
                    entities.SaveChanges();
                    MessageBox.Show("Product updated!");
                    ShowAllRecords();
                }
                else
                {
                    MessageBox.Show("Product cannot found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection occured with an error\n" + ex.Message);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (textBoxPrice.Text.ToString().Length == 0)
            {
                var products = (from product in entities.Products
                                where DbFunctions.Like(product.ProductName, textBoxName.Text.ToString() + "%")
                                select product).ToList();
                dataGridView1.DataSource = products;
            }
            else
            {
                int price = Convert.ToInt32(textBoxPrice.Text);
                var products = (from product in entities.Products
                                where DbFunctions.Like(product.ProductName, textBoxName.Text.ToString() + "%") &&
                                product.Price == price
                                select product).ToList();
                dataGridView1.DataSource = products;
            }
        }
    }
}
