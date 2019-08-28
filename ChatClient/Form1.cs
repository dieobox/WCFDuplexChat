using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatClient.ServiceReference1;


namespace ChatClient
{
    public partial class Form1 : Form
    {
        private ServiceReference1.Service1Client cnt;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            cnt = new ServiceReference1.Service1Client(new InstanceContext(new AcceptCallBack(this)));
            cnt.Open();
            cnt.Connect(NameEdit.Text);
            SendButton.Enabled = true;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (cnt.State == CommunicationState.Opened)
            {
                cnt.SendMessage(NameEdit.Text, SendMessageEdit.Text);
            }

        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (cnt.State == CommunicationState.Opened)
            {
                if (cnt.Disconnect(NameEdit.Text))
                {
                    cnt.Close();
                    MessageBox.Show("Disconnected");
                }
            }
        }
    }
    public class AcceptCallBack : IService1Callback
    {
        private Form1 form;
        public AcceptCallBack(Form1 frm)
        {
            form = frm;
        }

        public void GetMessage(string message)
        {
            form.ChatBox.Text += message;
        }

        public void Updatestatus(string status)
        {
            form.ChatBox.Text += status;
        }
    }
}
