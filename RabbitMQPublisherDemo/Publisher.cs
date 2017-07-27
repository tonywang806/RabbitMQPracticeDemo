using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using Common.Model;
using Common.Utils;

namespace RabbitMQPublisherDemo
{
    public partial class Publisher : Form
    {
        public Publisher()
        {
            InitializeComponent();
        }

        private void btnMsgDelivery_Click(object sender, EventArgs e)
        {
            var message = new MessageModel();

            message.MsgID = Guid.NewGuid().ToString();
            message.MsgRecOrder = this.txtRecOrder.Text;
            message.MsgCreateUser = this.txtCreateUser.Text;
            message.MsgCreateDateTime = DateTime.Now.ToShortTimeString();
            message.MsgSloveDept = this.cmbDeliveryDept.Text;
            message.MsgSloveUser = this.txtDeliveryUser.Text;
            message.MsgContent = this.txtMsgContent.Text;

            try
            {

                Productor.SentMessage(message, this.cmbDeliveryDept.Text);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("メッセージ発送失敗:{0}",ex.Message);
            }

        }
    }
}
