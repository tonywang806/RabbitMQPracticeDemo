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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnReceiveMsgStart = new System.Windows.Forms.Button();
            this.btnRecevieMsgStop = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatusLableText = new System.Windows.Forms.ToolStripStatusLabel();
            this.grdMsgDetils = new System.Windows.Forms.DataGridView();
            this.MsgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgCreateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgCreateDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgRecOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgwConsume = new System.ComponentModel.BackgroundWorker();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.tmReceiveFlashLight = new System.Windows.Forms.Timer(this.components);
            this.cmbUser = new System.Windows.Forms.ComboBox();
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
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(19, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 12);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "担当者";
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
            this.btnRecevieMsgStop.Enabled = false;
            this.btnRecevieMsgStop.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRecevieMsgStop.Location = new System.Drawing.Point(330, 12);
            this.btnRecevieMsgStop.Name = "btnRecevieMsgStop";
            this.btnRecevieMsgStop.Size = new System.Drawing.Size(140, 44);
            this.btnRecevieMsgStop.TabIndex = 3;
            this.btnRecevieMsgStop.Text = "受信終了";
            this.btnRecevieMsgStop.UseVisualStyleBackColor = true;
            this.btnRecevieMsgStop.Click += new System.EventHandler(this.btnRecevieMsgStop_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLable,
            this.tsStatusLableText});
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
            this.tsStatusLable.Size = new System.Drawing.Size(18, 18);
            // 
            // tsStatusLableText
            // 
            this.tsStatusLableText.Name = "tsStatusLableText";
            this.tsStatusLableText.Size = new System.Drawing.Size(55, 18);
            this.tsStatusLableText.Text = "受信停止";
            // 
            // grdMsgDetils
            // 
            this.grdMsgDetils.AllowUserToAddRows = false;
            this.grdMsgDetils.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMsgDetils.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMsgDetils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMsgDetils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MsgID,
            this.MsgCreateUser,
            this.MsgCreateDateTime,
            this.MsgRecOrder,
            this.MsgContent});
            this.grdMsgDetils.Location = new System.Drawing.Point(0, 62);
            this.grdMsgDetils.Name = "grdMsgDetils";
            this.grdMsgDetils.ReadOnly = true;
            this.grdMsgDetils.RowTemplate.Height = 21;
            this.grdMsgDetils.Size = new System.Drawing.Size(746, 231);
            this.grdMsgDetils.TabIndex = 4;
            this.grdMsgDetils.TabStop = false;
            // 
            // MsgID
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MsgID.DefaultCellStyle = dataGridViewCellStyle7;
            this.MsgID.HeaderText = "メッセージID";
            this.MsgID.Name = "MsgID";
            this.MsgID.ReadOnly = true;
            this.MsgID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MsgID.Width = 200;
            // 
            // MsgCreateUser
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MsgCreateUser.DefaultCellStyle = dataGridViewCellStyle8;
            this.MsgCreateUser.HeaderText = "発信者";
            this.MsgCreateUser.Name = "MsgCreateUser";
            this.MsgCreateUser.ReadOnly = true;
            this.MsgCreateUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MsgCreateUser.Width = 80;
            // 
            // MsgCreateDateTime
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MsgCreateDateTime.DefaultCellStyle = dataGridViewCellStyle9;
            this.MsgCreateDateTime.HeaderText = "発信日時";
            this.MsgCreateDateTime.Name = "MsgCreateDateTime";
            this.MsgCreateDateTime.ReadOnly = true;
            this.MsgCreateDateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MsgCreateDateTime.Width = 80;
            // 
            // MsgRecOrder
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MsgRecOrder.DefaultCellStyle = dataGridViewCellStyle10;
            this.MsgRecOrder.HeaderText = "受注番号";
            this.MsgRecOrder.Name = "MsgRecOrder";
            this.MsgRecOrder.ReadOnly = true;
            this.MsgRecOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MsgRecOrder.Width = 80;
            // 
            // MsgContent
            // 
            this.MsgContent.HeaderText = "メッセージ内容";
            this.MsgContent.Name = "MsgContent";
            this.MsgContent.ReadOnly = true;
            this.MsgContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MsgContent.Width = 300;
            // 
            // bgwConsume
            // 
            this.bgwConsume.WorkerSupportsCancellation = true;
            this.bgwConsume.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsume_DoWork);
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Dept.A",
            "Dept.B",
            "Dept.C"});
            this.cmbDept.Location = new System.Drawing.Point(65, 11);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(100, 20);
            this.cmbDept.TabIndex = 5;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedValueChanged);
            // 
            // tmReceiveFlashLight
            // 
            this.tmReceiveFlashLight.Interval = 300;
            this.tmReceiveFlashLight.Tick += new System.EventHandler(this.tmReceiveFlashLight_Tick);
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(65, 36);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(100, 20);
            this.cmbUser.TabIndex = 6;
            // 
            // Subscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 312);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.grdMsgDetils);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnRecevieMsgStop);
            this.Controls.Add(this.btnReceiveMsgStart);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Subscriber";
            this.Text = "メッセージ受信端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subscriber_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMsgDetils)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnReceiveMsgStart;
        private System.Windows.Forms.Button btnRecevieMsgStop;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLable;
        private System.Windows.Forms.DataGridView grdMsgDetils;
        private System.ComponentModel.BackgroundWorker bgwConsume;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgCreateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgCreateDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgRecOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgContent;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Timer tmReceiveFlashLight;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLableText;
        private System.Windows.Forms.ComboBox cmbUser;
    }
}

