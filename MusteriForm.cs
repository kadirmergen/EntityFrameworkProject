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
    public partial class CustomerForm : Form
    {
        ProjectsDBEntities entities = new ProjectsDBEntities();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ShowAllDatas();
        }

        private void ShowAllDatas()
        {
            //var customers = entities.Customerss.ToList();
            //dataGridView1.DataSource = customers;
            var customers = (from customer in entities.Customerss
                             select new
                             {
                                 customer.CustomerId,
                                 customer.FirstName,
                                 customer.LastName,
                                 customer.Address
                             }).ToList();
            dataGridView1.DataSource = customers;
            dataGridView1.ClearSelection();
            ClearAllSelection();
            labelNumberofCustomer.Text = entities.Customerss.Count().ToString();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ShowAllDatas();
            textBoxCustomerId.Text = "0";
            labelNumberofCustomer.Text = entities.Customerss.Count().ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customerss customer = new Customerss();
            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.Address = textBoxAddress.Text;
            try
            {
                entities.Customerss.Add(customer);
                entities.SaveChanges();
                MessageBox.Show("Customer added!");
                ShowAllDatas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error occured on to connection to database\n" + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAllSelection();
        }

        private void ClearAllSelection()
        {
            textBoxCustomerId.Text = "0";
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxAddress.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text.Equals("0"))
            {
                MessageBox.Show("Please select a customer.");
            }
            else 
            {
                    try
                    {
                        int customerId = Convert.ToInt32(textBoxCustomerId.Text);
                        var customer = entities.Customerss.Find(customerId);
                        if (customer != null) 
                        {
                            entities.Customerss.Remove(customer);
                            entities.SaveChanges();
                            MessageBox.Show("Customer removed.");
                            ShowAllDatas();
                        }
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show("Error: " + ex.Message);
                    }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRows = dataGridView1.SelectedCells[0].RowIndex;
            textBoxCustomerId.Text = dataGridView1.Rows[selectedRows].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.Rows[selectedRows].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.Rows[selectedRows].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[selectedRows].Cells[3].Value.ToString();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text.Equals("0"))
            {
                MessageBox.Show("Please select a customer.");
            }
            else 
            {
                try
                {
                    int customerId = Convert.ToInt32(textBoxCustomerId.Text);
                    var customer = entities.Customerss.Find(customerId);
                    if (customer != null) 
                    {
                        customer.FirstName = textBoxFirstName.Text;
                        customer.LastName = textBoxLastName.Text;
                        customer.Address = textBoxAddress.Text;
                        entities.SaveChanges();
                        MessageBox.Show("Customer updated!");
                        ShowAllDatas();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var customers = (from customer in entities.Customerss
                             where DbFunctions.Like(customer.FirstName, textBoxFirstName.Text.ToString() + "%") &&
                                    DbFunctions.Like(customer.LastName, textBoxLastName.Text.ToString() + "%") &&
                                    DbFunctions.Like(customer.Address, textBoxAddress.Text.ToString() + "%")
                             select customer).ToList();
            dataGridView1.DataSource = customers;
        }
    }
}
