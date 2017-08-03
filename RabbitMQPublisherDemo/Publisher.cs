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
using Common;
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

            if (!EntryCheck())
            {
                return;
            }




            var message = new MessageModel();

            message.MsgID = Guid.NewGuid().ToString();
            message.MsgRecOrder = this.txtRecOrder.Text;
            message.MsgCreateUser = this.txtCreateUser.Text;
            message.MsgCreateDateTime = DateTime.Now.ToShortTimeString();
            message.MsgSloveDept = this.cmbDeliveryDept.Text;
            message.MsgSloveUser = this.cmbDeliveryUser.Text;
            message.MsgContent = this.txtMsgContent.Text;

            try
            {
                string exchangeName = "";
                string routingKey = "";
                EnumTransferType t = EnumTransferType.All;

                if (rdbAll.Checked)
                {
                    exchangeName = "All";
                    routingKey = "";
                    t = EnumTransferType.All;
                }

                if (rdbDept.Checked)
                {
                    exchangeName = "Dept";
                    routingKey = cmbDeliveryDept.Text.Remove(4,1);
                    t = EnumTransferType.Dept;
                }

                if (rdbUser.Checked)
                {
                    exchangeName = "";
                    routingKey = cmbDeliveryUser.Text;
                    t = EnumTransferType.User;
                }

                RadioButton prority = pnlPrority.Controls.OfType<RadioButton>().SingleOrDefault(radio => radio.Checked == true);
                message.Priority = int.Parse(prority.Text);

                Productor.SentMessage(t,exchangeName, routingKey,message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("メッセージ発送失敗:{0}",ex.Message);
            }

        }

        private void cmbDeliveryDept_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDeliveryUser.Text = string.Empty;
            cmbDeliveryUser.Items.Clear();

            switch (cmbDeliveryDept.Text)
            {
                case "Dept.A":
                    cmbDeliveryUser.Items.Add("UserA");
                    cmbDeliveryUser.Items.Add("UserB");
                    cmbDeliveryUser.Items.Add("UserC");
                    cmbDeliveryUser.Items.Add("UserD");
                    cmbDeliveryUser.Items.Add("UserE");
                    break;
                case "Dept.B":
                    cmbDeliveryUser.Items.Add("UserF");
                    cmbDeliveryUser.Items.Add("UserG");
                    break;
                case "Dept.C":
                    cmbDeliveryUser.Items.Add("UserH");
                    cmbDeliveryUser.Items.Add("UserI");
                    cmbDeliveryUser.Items.Add("UserPrority");
                    break;
                default:
                    break;
            }

        }

        private bool EntryCheck()
        {
            if (rdbDept.Checked) {
                if (string.IsNullOrEmpty(cmbDeliveryDept.Text))
                {
                    MessageBox.Show("部署を指定してください。");
                    return false;
                }
            }

            if (rdbUser.Checked)
            {
                if (string.IsNullOrEmpty(cmbDeliveryUser.Text))
                {
                    MessageBox.Show("ユーザーを指定してください。");
                    return false;
                }
            }

            return true;
        }
    }
}
