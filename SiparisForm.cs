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
    public partial class SiparisForm : Form
    {
        ProjectsDBEntities entities = new ProjectsDBEntities();
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            ShowAllRecords();
            dataGridView1.ClearSelection();

            var customers = (from customer in entities.Customerss select new
            {
                customer.CustomerId,
                FullName=customer.FirstName + " " + customer.LastName,
                
            }).ToList();
            comboBoxCustomerId.ValueMember = "CustomerId";
            comboBoxCustomerId.DisplayMember = "FullName";
            comboBoxCustomerId.DataSource = customers;

            var products = (from product in entities.Products select new
            {
                product.ProductId,
                ProductInfo = product.ProductName + " - " + product.Price.ToString() + "₺"
            }).ToList();
            comboBoxProductId.ValueMember = "ProductId";
            comboBoxProductId.DisplayMember = "ProductInfo";
            comboBoxProductId.DataSource = products;
        }

        private void buttonListForAll_Click(object sender, EventArgs e)
        {
            ShowAllRecords();
        }

        private void ShowAllRecords()
        {
            var orders = (from order in entities.Orders select new
            {
                order.OrderId,
                order.OrderDate,
                order.Customerss.CustomerId,
                order.Products.ProductId,
                order.Quantity
            }).ToList();
            dataGridView1.DataSource = orders;
            dataGridView1.ClearSelection();
            ClearAllBoxes();
        }

        private void ClearAllBoxes()
        {
            textBoxOrderId.Text = "0";
            textBoxQuantity.Clear();
            dateTimePicker1.Value = DateTime.Now;
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Orders order = new Orders();
                order.OrderDate = dateTimePicker1.Value;
                order.CustomerId = Convert.ToInt32(comboBoxCustomerId.SelectedValue.ToString());
                order.ProductId = Convert.ToInt32(comboBoxProductId.SelectedValue.ToString());
                order.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                entities.Orders.Add(order);
                entities.SaveChanges();

                ShowAllRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error occured\n"+ ex.Message);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedOrder = dataGridView1.SelectedCells[0].RowIndex;
            textBoxOrderId.Text = dataGridView1.Rows[selectedOrder].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[selectedOrder].Cells[1].Value.ToString();
            int customerId = Convert.ToInt32(dataGridView1.Rows[selectedOrder].Cells[2].Value.ToString());
            comboBoxCustomerId.SelectedValue = customerId;
            int productId = Convert.ToInt32(dataGridView1.Rows[selectedOrder ].Cells[3].Value.ToString());
            comboBoxProductId.SelectedValue = productId;
            textBoxQuantity.Text = dataGridView1.Rows[selectedOrder].Cells[4].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(textBoxOrderId.Text);
                var order = entities.Orders.Find(orderId);
                if (order != null)
                {
                    order.OrderDate = dateTimePicker1.Value;
                    order.CustomerId = Convert.ToInt32(comboBoxCustomerId.SelectedValue.ToString());
                    order.ProductId = Convert.ToInt32(comboBoxProductId.SelectedValue.ToString());
                    order.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                    entities.SaveChanges();
                    ShowAllRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error occured\n" + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(textBoxOrderId.Text);
                var order = entities.Orders.Find(orderId);
                if(order != null)
                {
                    entities.Orders.Remove(order);
                    entities.SaveChanges();
                    ShowAllRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error occured\n" + ex.Message);
            }
        }

        private void buttonClearAllTextBox_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }
    }
}