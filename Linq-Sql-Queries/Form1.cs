using Linq_Sql_Queries.Data_Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Sql_Queries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdventureWorksLT2017Entities db = new AdventureWorksLT2017Entities();
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtTextbox.Text);
            var delete = db.Customers.Single(c=>c.CustomerID==value);
            db.Customers.Remove(delete);
            db.SaveChanges();
            MessageBox.Show("Transaction Successful");
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtTextBox2.Text);
            var customer = db.Customers.Single(c=>c.CustomerID==value);
            customer.EmailAddress = txtTextBox3.Text;
            db.SaveChanges();
            MessageBox.Show("Transaction Successful");
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txttextBox5.Text);
            ProductDescription description = new ProductDescription()
            {
                 rowguid=Guid.NewGuid(),
                  Description=txttextBox4.Text,
                  ProductDescriptionID=value,
                   ModifiedDate=DateTime.Now
            };
            db.ProductDescriptions.Add(description);
            db.SaveChanges();
            MessageBox.Show("Transaction Successful");
        }
    }
}
