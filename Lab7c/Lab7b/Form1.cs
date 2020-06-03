using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Lab7b
{
    public partial class Form1 : Form
    {
        MyServiceClient client = null;

        public Form1()
        {
            InitializeComponent();

            Try_To_Create_New_Client();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Convert.ToString(this.client.GetAll());
        }

        private void Post_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            int number = Convert.ToInt32(this.name.Text);

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
            int number = Convert.ToInt32(this.name.Text);
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

        private void Try_To_Create_New_Client()
        {
            try
            {
                NetTcpBinding binding = new NetTcpBinding(SecurityMode.Transport);

                binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
                binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
                binding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;


                string uri = "net.tcp://localhost:9002/MyService";

                EndpointAddress endpoint = new EndpointAddress(new Uri(uri));

                client = new MyServiceClient(binding, endpoint);

                //client.ClientCredentials.Windows.ClientCredential.Domain = "";
                //client.ClientCredentials.Windows.ClientCredential.UserName = "Vasya";
                //client.ClientCredentials.Windows.ClientCredential.Password = "12345";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
                client = null;
            }
        }

    }
}
