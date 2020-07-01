using lab07c_winforms.WS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab07b_winforms
{
    public partial class Form1 : Form
    {
        lab07c_winforms.WS.ContactsServiceClient client;
        public Form1()
        {
            InitializeComponent();
            this.client = new ContactsServiceClient();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Convert.ToString(this.client.GetAll());
        }

        private void Post_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            int number;
            if (!int.TryParse(this.num.Text, out number) || this.name.Text == "" || this.num.Text == "")
            {
                MessageBox.Show("ERROR");
                return;
            }
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

            int id, number;
            if (!int.TryParse(this.num.Text, out number) || !int.TryParse(this.id.Text, out id) || this.id.Text == "" || this.name.Text == "" || this.num.Text == "")
            {
                MessageBox.Show("ERROR");
                return;
            }
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
            int id;
            if (!int.TryParse(this.id.Text, out id) || this.id.Text == "")
            {
                MessageBox.Show("ERROR");
                return;
            }

            if (this.client.DelDict(id) == "OK")
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
