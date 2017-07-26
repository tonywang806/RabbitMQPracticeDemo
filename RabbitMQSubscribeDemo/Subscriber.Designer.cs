namespace RabbitMQSubscribeDemo
{
    partial class Subscriber
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnReceiveMsgStart = new System.Windows.Forms.Button();
            this.btnRecevieMsgStop = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.grdMsgDetils = new System.Windows.Forms.DataGridView();
            this.MsgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgCreateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgCreateDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgRecOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgwConsume = new System.ComponentModel.BackgroundWorker();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMsgDetils)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(19, 15);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(29, 12);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "部署";
            // 
            // txtDept
            // 
            this.txtDept.CausesValidation = false;
            this.txtDept.Location = new System.Drawing.Point(65, 12);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 19);
            this.txtDept.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(19, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 12);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "担当者";
            // 
            // txtUser
            // 
            this.txtUser.CausesValidation = false;
            this.txtUser.Location = new System.Drawing.Point(65, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 19);
            this.txtUser.TabIndex = 1;
            // 
            // btnReceiveMsgStart
            // 
            this.btnReceiveMsgStart.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReceiveMsgStart.Location = new System.Drawing.Point(184, 12);
            this.btnReceiveMsgStart.Name = "btnReceiveMsgStart";
            this.btnReceiveMsgStart.Size = new System.Drawing.Size(140, 44);
            this.btnReceiveMsgStart.TabIndex = 2;
            this.btnReceiveMsgStart.Text = "受信開始";
            this.btnReceiveMsgStart.UseVisualStyleBackColor = true;
            this.btnReceiveMsgStart.Click += new System.EventHandler(this.btnReceiveMsgStart_Click);
            // 
            // btnRecevieMsgStop
            // 
            this.btnRecevieMsgStop.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRecevieMsgStop.Location = new System.Drawing.Point(330, 12);
            this.btnRecevieMsgStop.Name = "btnRecevieMsgStop";
            this.btnRecevieMsgStop.Size = new System.Drawing.Size(140, 44);
            this.btnRecevieMsgStop.TabIndex = 2;
            this.btnRecevieMsgStop.Text = "受信終了";
            this.btnRecevieMsgStop.UseVisualStyleBackColor = true;
            this.btnRecevieMsgStop.Click += new System.EventHandler(this.btnRecevieMsgStop_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLable});
            this.statusStrip.Location = new System.Drawing.Point(0, 289);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(746, 23);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsStatusLable
            // 
            this.tsStatusLable.AutoSize = false;
            this.tsStatusLable.BackColor = System.Drawing.Color.Red;
            this.tsStatusLable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tsStatusLable.Name = "tsStatusLable";
            this.tsStatusLable.Size = new System.Drawing.Size(100, 18);
            this.tsStatusLable.Text = "受信停止";
            // 
            // grdMsgDetils
            // 
            this.grdMsgDetils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMsgDetils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MsgID,
            this.MsgCreateUser,
            this.MsgCreateDateTime,
            this.MsgRecOrder,
            this.MsgContent});
            this.grdMsgDetils.Location = new System.Drawing.Point(0, 62);
            this.grdMsgDetils.Name = "grdMsgDetils";
            this.grdMsgDetils.RowTemplate.Height = 21;
            this.grdMsgDetils.Size = new System.Drawing.Size(746, 231);
            this.grdMsgDetils.TabIndex = 4;
            // 
            // MsgID
            // 
            this.MsgID.HeaderText = "メッセージID";
            this.MsgID.Name = "MsgID";
            // 
            // MsgCreateUser
            // 
            this.MsgCreateUser.HeaderText = "発信者";
            this.MsgCreateUser.Name = "MsgCreateUser";
            // 
            // MsgCreateDateTime
            // 
            this.MsgCreateDateTime.HeaderText = "発信日時";
            this.MsgCreateDateTime.Name = "MsgCreateDateTime";
            // 
            // MsgRecOrder
            // 
            this.MsgRecOrder.HeaderText = "受注番号";
            this.MsgRecOrder.Name = "MsgRecOrder";
            // 
            // MsgContent
            // 
            this.MsgContent.HeaderText = "メッセージ内容";
            this.MsgContent.Name = "MsgContent";
            // 
            // bgwConsume
            // 
            this.bgwConsume.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsume_DoWork);
            // 
            // Subscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 312);
            this.Controls.Add(this.grdMsgDetils);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnRecevieMsgStop);
            this.Controls.Add(this.btnReceiveMsgStart);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblDept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Subscriber";
            this.Text = "メッセージ受信端";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMsgDetils)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnReceiveMsgStart;
        private System.Windows.Forms.Button btnRecevieMsgStop;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLable;
        private System.Windows.Forms.DataGridView grdMsgDetils;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgCreateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgCreateDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgRecOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgContent;
        private System.ComponentModel.BackgroundWorker bgwConsume;
    }
}

