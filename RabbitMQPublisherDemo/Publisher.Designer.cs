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
            this.txtRecOrder = new System.Windows.Forms.TextBox();
            this.lblRecOrder = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.txtDeliveryDept = new System.Windows.Forms.TextBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.txtDeliveryUser = new System.Windows.Forms.TextBox();
            this.lblMsgContent = new System.Windows.Forms.Label();
            this.btnMsgDelivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsgContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRecOrder
            // 
            this.txtRecOrder.Location = new System.Drawing.Point(89, 32);
            this.txtRecOrder.Name = "txtRecOrder";
            this.txtRecOrder.Size = new System.Drawing.Size(246, 19);
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
            this.txtCreateUser.Location = new System.Drawing.Point(89, 57);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(246, 19);
            this.txtCreateUser.TabIndex = 0;
            // 
            // lblCreateUser
            // 
            this.lblCreateUser.AutoSize = true;
            this.lblCreateUser.Location = new System.Drawing.Point(30, 60);
            this.lblCreateUser.Name = "lblCreateUser";
            this.lblCreateUser.Size = new System.Drawing.Size(41, 12);
            this.lblCreateUser.TabIndex = 1;
            this.lblCreateUser.Text = "作成者";
            // 
            // txtDeliveryDept
            // 
            this.txtDeliveryDept.Location = new System.Drawing.Point(138, 82);
            this.txtDeliveryDept.Name = "txtDeliveryDept";
            this.txtDeliveryDept.Size = new System.Drawing.Size(197, 19);
            this.txtDeliveryDept.TabIndex = 0;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(30, 85);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(41, 12);
            this.lblDelivery.TabIndex = 1;
            this.lblDelivery.Text = "発送先";
            // 
            // txtDeliveryUser
            // 
            this.txtDeliveryUser.Location = new System.Drawing.Point(138, 107);
            this.txtDeliveryUser.Name = "txtDeliveryUser";
            this.txtDeliveryUser.Size = new System.Drawing.Size(197, 19);
            this.txtDeliveryUser.TabIndex = 0;
            // 
            // lblMsgContent
            // 
            this.lblMsgContent.AutoSize = true;
            this.lblMsgContent.Location = new System.Drawing.Point(9, 139);
            this.lblMsgContent.Name = "lblMsgContent";
            this.lblMsgContent.Size = new System.Drawing.Size(74, 12);
            this.lblMsgContent.TabIndex = 1;
            this.lblMsgContent.Text = "メッセージ内容";
            // 
            // btnMsgDelivery
            // 
            this.btnMsgDelivery.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.btnMsgDelivery.Location = new System.Drawing.Point(32, 265);
            this.btnMsgDelivery.Name = "btnMsgDelivery";
            this.btnMsgDelivery.Size = new System.Drawing.Size(303, 93);
            this.btnMsgDelivery.TabIndex = 3;
            this.btnMsgDelivery.Text = "発　信";
            this.btnMsgDelivery.UseVisualStyleBackColor = true;
            this.btnMsgDelivery.Click += new System.EventHandler(this.btnMsgDelivery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "部署";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "担当者";
            // 
            // txtMsgContent
            // 
            this.txtMsgContent.Location = new System.Drawing.Point(89, 139);
            this.txtMsgContent.Multiline = true;
            this.txtMsgContent.Name = "txtMsgContent";
            this.txtMsgContent.Size = new System.Drawing.Size(246, 105);
            this.txtMsgContent.TabIndex = 4;
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 382);
            this.Controls.Add(this.txtMsgContent);
            this.Controls.Add(this.btnMsgDelivery);
            this.Controls.Add(this.lblMsgContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblCreateUser);
            this.Controls.Add(this.lblRecOrder);
            this.Controls.Add(this.txtDeliveryUser);
            this.Controls.Add(this.txtDeliveryDept);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.txtRecOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Publisher";
            this.Text = "メッセージ発信端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecOrder;
        private System.Windows.Forms.Label lblRecOrder;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.TextBox txtDeliveryDept;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.TextBox txtDeliveryUser;
        private System.Windows.Forms.Label lblMsgContent;
        private System.Windows.Forms.Button btnMsgDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsgContent;
    }
}

