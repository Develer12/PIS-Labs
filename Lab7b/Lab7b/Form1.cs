using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7b
{
    public partial class Form1 : Form
    {
        WS.WebServiceSoapClient client;

        public Form1()
        {
            InitializeComponent();

            this.client = new WS.WebServiceSoapClient();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Convert.ToString(this.client.GetAll());
        }

        private void Post_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            int number = Convert.ToInt32(this.num.Text);

            if (this.client.AddDict(name, number) == "OK")
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Put_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            int number = Convert.ToInt32(this.num.Text);
            int id = Convert.ToInt32(this.id.Text);

            if (this.client.UpdDict(id, name, number) == "OK")
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.id.Text);

            if (this.client.DelDict(id) == "OK")
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
