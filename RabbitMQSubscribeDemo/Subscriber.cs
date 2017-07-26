using Common.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQSubscribeDemo
{
    public partial class Subscriber : Form
    {
        SubMessagesWithCallBack receiver = null;
        public Subscriber()
        {
            InitializeComponent();
        }

        private void btnReceiveMsgStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtDept.Text))
            {
                MessageBox.Show("部署と担当者がいずれか入力してください！");
                return;
            }

            tsStatusLable.Text = "受信中";
            tsStatusLable.BackColor = Color.Green;

            //受信処理起動
            SubMessagesWithCallBack.GetMessage(new SubMessagesWithCallBack.MessageReceivedEvent(MessageReceivedHandle));
        }

        private void btnRecevieMsgStop_Click(object sender, EventArgs e)
        {
            //受信処理停止
            tsStatusLable.Text = "受信停止";
            tsStatusLable.BackColor = Color.Red;
            try
            {
                receiver.Dispose();
            } catch (Exception ex)
            {
                Debug.WriteLine("Receiver Stop Error:{0}",ex.Message);
            }
            finally
            {
                receiver = null;
            }

        }

        private void MessageReceivedHandle(Common.Model.MessageModel msg)
        {
            try
            {
                C1.Win.C1FlexGrid.Row r = grdMsgDetils.Rows.Add();
                grdMsgDetils.SetData(r.Index, 0, msg.MsgID);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Grid Data Setting Error:{0}", ex.Message);
            }

        }
    }
}
