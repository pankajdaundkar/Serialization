using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace nwe_product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSOAPwrit_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\prod.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                Product p1 = new Product();
                SoapFormatter soapFormatter = new SoapFormatter();
                p1.Id = Convert.ToInt32(txtproid.Text);
                p1.Name = txtproname.Text; ;
                p1.Price = Convert.ToInt32(txtpropri.Text);
                soapFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\prod.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
              BinaryFormatter formatter = new BinaryFormatter();
             Product p1 = new Product();
             // we done explicit type casting from Object --> Product
             p1 = (Product)formatter.Deserialize(fileStream);
             txtproid.Text = p1.Id.ToString();
             txtproname.Text = p1.Name;
             txtpropri.Text = p1.Price.ToString();
            
             fileStream.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\prod.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtproid.Text);
                p1.Name = txtproname.Text; ;
                p1.Price = Convert.ToInt32(txtpropri.Text);
                binaryFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\prod.xml";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtproid.Text);
                p1.Name = txtproname.Text; ;
                p1.Price = Convert.ToInt32(txtpropri.Text);
                xmlSerializer.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLread_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"C:\DP4-2-Aug\prod.xml";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product)); Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)xmlSerializer.Deserialize(fileStream);
                txtproid.Text = p1.Id.ToString();
                txtproname.Text = p1.Name;
                txtpropri.Text = p1.Price.ToString();

                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPread_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"C:\DP4-2-Aug\prod.soap";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                // we done explicit type casting from Object --> Product
                SoapFormatter soapFormatter = new SoapFormatter();
                Product p1 = new Product();
                p1 = (Product)soapFormatter.Deserialize(fileStream);
                txtproid.Text = p1.Id.ToString();
                txtproname.Text = p1.Name;
                txtpropri.Text = p1.Price.ToString();

                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJOSNwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\prod.json";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtproid.Text);
                p1.Name = txtproname.Text; ;
                p1.Price = Convert.ToInt32(txtpropri.Text);
                JsonSerializer.Serialize<Product>(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJOSNread_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"C:\DP4-2-Aug\prod.json";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                // we done explicit type casting from Object --> Product
                Product p1 = new Product();
                p1=JsonSerializer.Deserialize<Product>(fileStream);
                txtproid.Text = p1.Id.ToString();
                txtproname.Text = p1.Name;
                txtpropri.Text = p1.Price.ToString();

                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

    }

