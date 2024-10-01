using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProductTransactions_Click(object sender, EventArgs e)
        {
            UrunForm urunForm = new UrunForm();
            urunForm.Show();
        }

        private void buttonCustomerTransactions_Click(object sender, EventArgs e)
        {
            CustomerForm musteriForm = new CustomerForm();
            musteriForm.Show();
        }
        
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            SiparisForm siparisForm = new SiparisForm();
            siparisForm.Show();
        }
    }
}
