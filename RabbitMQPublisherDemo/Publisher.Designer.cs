namespace RabbitMQPublisherDemo
{
    partial class Publisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publisher));
            this.txtRecOrder = new System.Windows.Forms.TextBox();
            this.lblRecOrder = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblMsgContent = new System.Windows.Forms.Label();
            this.btnMsgDelivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsgContent = new System.Windows.Forms.TextBox();
            this.cmbDeliveryDept = new System.Windows.Forms.ComboBox();
            this.cmbDeliveryUser = new System.Windows.Forms.ComboBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbDept = new System.Windows.Forms.RadioButton();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPrority = new System.Windows.Forms.Panel();
            this.rdbPrority1 = new System.Windows.Forms.RadioButton();
            this.rdbPrority2 = new System.Windows.Forms.RadioButton();
            this.rdbPrority3 = new System.Windows.Forms.RadioButton();
            this.rdbPrority4 = new System.Windows.Forms.RadioButton();
            this.rdbPrority5 = new System.Windows.Forms.RadioButton();
            this.pnlScope = new System.Windows.Forms.Panel();
            this.pnlPrority.SuspendLayout();
            this.pnlScope.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRecOrder
            // 
            this.txtRecOrder.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtRecOrder.Location = new System.Drawing.Point(92, 32);
            this.txtRecOrder.Name = "txtRecOrder";
            this.txtRecOrder.Size = new System.Drawing.Size(243, 19);
            this.txtRecOrder.TabIndex = 0;
            // 
            // lblRecOrder
            // 
            this.lblRecOrder.AutoSize = true;
            this.lblRecOrder.Location = new System.Drawing.Point(30, 35);
            this.lblRecOrder.Name = "lblRecOrder";
            this.lblRecOrder.Size = new System.Drawing.Size(53, 12);
            this.lblRecOrder.TabIndex = 1;
            this.lblRecOrder.Text = "受注番号";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtCreateUser.Location = new System.Drawing.Point(92, 57);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(243, 19);
            this.txtCreateUser.TabIndex = 1;
            // 
            // lblCreateUser
            // 
            this.lblCreateUser.AutoSize = true;
            this.lblCreateUser.Location = new System.Drawing.Point(42, 60);
            this.lblCreateUser.Name = "lblCreateUser";
            this.lblCreateUser.Size = new System.Drawing.Size(41, 12);
            this.lblCreateUser.TabIndex = 1;
            this.lblCreateUser.Text = "作成者";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(42, 127);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(41, 12);
            this.lblDelivery.TabIndex = 1;
            this.lblDelivery.Text = "発送先";
            // 
            // lblMsgContent
            // 
            this.lblMsgContent.AutoSize = true;
            this.lblMsgContent.Location = new System.Drawing.Point(9, 209);
            this.lblMsgContent.Name = "lblMsgContent";
            this.lblMsgContent.Size = new System.Drawing.Size(74, 12);
            this.lblMsgContent.TabIndex = 1;
            this.lblMsgContent.Text = "メッセージ内容";
            // 
            // btnMsgDelivery
            // 
            this.btnMsgDelivery.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.btnMsgDelivery.Location = new System.Drawing.Point(32, 296);
            this.btnMsgDelivery.Name = "btnMsgDelivery";
            this.btnMsgDelivery.Size = new System.Drawing.Size(303, 93);
            this.btnMsgDelivery.TabIndex = 8;
            this.btnMsgDelivery.Text = "発　信";
            this.btnMsgDelivery.UseVisualStyleBackColor = true;
            this.btnMsgDelivery.Click += new System.EventHandler(this.btnMsgDelivery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "部署";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "担当者";
            // 
            // txtMsgContent
            // 
            this.txtMsgContent.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtMsgContent.Location = new System.Drawing.Point(92, 209);
            this.txtMsgContent.Multiline = true;
            this.txtMsgContent.Name = "txtMsgContent";
            this.txtMsgContent.Size = new System.Drawing.Size(243, 77);
            this.txtMsgContent.TabIndex = 7;
            // 
            // cmbDeliveryDept
            // 
            this.cmbDeliveryDept.FormattingEnabled = true;
            this.cmbDeliveryDept.Items.AddRange(new object[] {
            "Dept.A",
            "Dept.B",
            "Dept.C"});
            this.cmbDeliveryDept.Location = new System.Drawing.Point(160, 125);
            this.cmbDeliveryDept.Name = "cmbDeliveryDept";
            this.cmbDeliveryDept.Size = new System.Drawing.Size(175, 20);
            this.cmbDeliveryDept.TabIndex = 5;
            this.cmbDeliveryDept.SelectedValueChanged += new System.EventHandler(this.cmbDeliveryDept_SelectedValueChanged);
            // 
            // cmbDeliveryUser
            // 
            this.cmbDeliveryUser.FormattingEnabled = true;
            this.cmbDeliveryUser.Location = new System.Drawing.Point(160, 152);
            this.cmbDeliveryUser.Name = "cmbDeliveryUser";
            this.cmbDeliveryUser.Size = new System.Drawing.Size(175, 20);
            this.cmbDeliveryUser.TabIndex = 6;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(3, 3);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(47, 16);
            this.rdbAll.TabIndex = 2;
            this.rdbAll.Tag = "All";
            this.rdbAll.Text = "全員";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbDept
            // 
            this.rdbDept.AutoSize = true;
            this.rdbDept.Location = new System.Drawing.Point(90, 3);
            this.rdbDept.Name = "rdbDept";
            this.rdbDept.Size = new System.Drawing.Size(47, 16);
            this.rdbDept.TabIndex = 3;
            this.rdbDept.Tag = "Dept";
            this.rdbDept.Text = "部署";
            this.rdbDept.UseVisualStyleBackColor = true;
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Checked = true;
            this.rdbUser.Location = new System.Drawing.Point(177, 3);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(59, 16);
            this.rdbUser.TabIndex = 4;
            this.rdbUser.TabStop = true;
            this.rdbUser.Tag = "Staff";
            this.rdbUser.Text = "担当者";
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "通知範囲";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "優先度";
            // 
            // pnlPrority
            // 
            this.pnlPrority.Controls.Add(this.rdbPrority5);
            this.pnlPrority.Controls.Add(this.rdbPrority4);
            this.pnlPrority.Controls.Add(this.rdbPrority3);
            this.pnlPrority.Controls.Add(this.rdbPrority2);
            this.pnlPrority.Controls.Add(this.rdbPrority1);
            this.pnlPrority.Location = new System.Drawing.Point(89, 176);
            this.pnlPrority.Name = "pnlPrority";
            this.pnlPrority.Size = new System.Drawing.Size(252, 27);
            this.pnlPrority.TabIndex = 9;
            // 
            // rdbPrority1
            // 
            this.rdbPrority1.AutoSize = true;
            this.rdbPrority1.Location = new System.Drawing.Point(3, 3);
            this.rdbPrority1.Name = "rdbPrority1";
            this.rdbPrority1.Size = new System.Drawing.Size(29, 16);
            this.rdbPrority1.TabIndex = 0;
            this.rdbPrority1.Tag = "1";
            this.rdbPrority1.Text = "1";
            this.rdbPrority1.UseVisualStyleBackColor = true;
            // 
            // rdbPrority2
            // 
            this.rdbPrority2.AutoSize = true;
            this.rdbPrority2.Location = new System.Drawing.Point(54, 3);
            this.rdbPrority2.Name = "rdbPrority2";
            this.rdbPrority2.Size = new System.Drawing.Size(29, 16);
            this.rdbPrority2.TabIndex = 0;
            this.rdbPrority2.Tag = "2";
            this.rdbPrority2.Text = "2";
            this.rdbPrority2.UseVisualStyleBackColor = true;
            // 
            // rdbPrority3
            // 
            this.rdbPrority3.AutoSize = true;
            this.rdbPrority3.Checked = true;
            this.rdbPrority3.Location = new System.Drawing.Point(105, 3);
            this.rdbPrority3.Name = "rdbPrority3";
            this.rdbPrority3.Size = new System.Drawing.Size(29, 16);
            this.rdbPrority3.TabIndex = 0;
            this.rdbPrority3.TabStop = true;
            this.rdbPrority3.Tag = "3";
            this.rdbPrority3.Text = "3";
            this.rdbPrority3.UseVisualStyleBackColor = true;
            // 
            // rdbPrority4
            // 
            this.rdbPrority4.AutoSize = true;
            this.rdbPrority4.Location = new System.Drawing.Point(156, 3);
            this.rdbPrority4.Name = "rdbPrority4";
            this.rdbPrority4.Size = new System.Drawing.Size(29, 16);
            this.rdbPrority4.TabIndex = 0;
            this.rdbPrority4.Tag = "4";
            this.rdbPrority4.Text = "4";
            this.rdbPrority4.UseVisualStyleBackColor = true;
            // 
            // rdbPrority5
            // 
            this.rdbPrority5.AutoSize = true;
            this.rdbPrority5.Location = new System.Drawing.Point(207, 3);
            this.rdbPrority5.Name = "rdbPrority5";
            this.rdbPrority5.Size = new System.Drawing.Size(29, 16);
            this.rdbPrority5.TabIndex = 0;
            this.rdbPrority5.Tag = "5";
            this.rdbPrority5.Text = "5";
            this.rdbPrority5.UseVisualStyleBackColor = true;
            // 
            // pnlScope
            // 
            this.pnlScope.Controls.Add(this.rdbDept);
            this.pnlScope.Controls.Add(this.rdbAll);
            this.pnlScope.Controls.Add(this.rdbUser);
            this.pnlScope.Location = new System.Drawing.Point(90, 87);
            this.pnlScope.Name = "pnlScope";
            this.pnlScope.Size = new System.Drawing.Size(252, 27);
            this.pnlScope.TabIndex = 10;
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 401);
            this.Controls.Add(this.pnlScope);
            this.Controls.Add(this.pnlPrority);
            this.Controls.Add(this.cmbDeliveryUser);
            this.Controls.Add(this.cmbDeliveryDept);
            this.Controls.Add(this.txtMsgContent);
            this.Controls.Add(this.btnMsgDelivery);
            this.Controls.Add(this.lblMsgContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCreateUser);
            this.Controls.Add(this.lblRecOrder);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.txtRecOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Publisher";
            this.Text = "メッセージ発信端";
            this.pnlPrority.ResumeLayout(false);
            this.pnlPrority.PerformLayout();
            this.pnlScope.ResumeLayout(false);
            this.pnlScope.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecOrder;
        private System.Windows.Forms.Label lblRecOrder;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblMsgContent;
        private System.Windows.Forms.Button btnMsgDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsgContent;
        private System.Windows.Forms.ComboBox cmbDeliveryDept;
        private System.Windows.Forms.ComboBox cmbDeliveryUser;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbDept;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPrority;
        private System.Windows.Forms.RadioButton rdbPrority2;
        private System.Windows.Forms.RadioButton rdbPrority1;
        private System.Windows.Forms.RadioButton rdbPrority5;
        private System.Windows.Forms.RadioButton rdbPrority4;
        private System.Windows.Forms.RadioButton rdbPrority3;
        private System.Windows.Forms.Panel pnlScope;
    }
}

