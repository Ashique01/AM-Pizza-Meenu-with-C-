namespace pizzaMenu
{
    partial class pizzaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.rdoItemDeluxe = new System.Windows.Forms.RadioButton();
            this.rdoItem4 = new System.Windows.Forms.RadioButton();
            this.rdoItem3 = new System.Windows.Forms.RadioButton();
            this.rdoItem2 = new System.Windows.Forms.RadioButton();
            this.rdoItem1 = new System.Windows.Forms.RadioButton();
            this.grpBox3 = new System.Windows.Forms.GroupBox();
            this.chkBoxCoupon = new System.Windows.Forms.CheckBox();
            this.chkBoxDelivery = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.grpBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rdoLarge);
            this.grpBox.Controls.Add(this.rdoMedium);
            this.grpBox.Controls.Add(this.rdoSmall);
            this.grpBox.Location = new System.Drawing.Point(12, 67);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(174, 136);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(6, 84);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(135, 17);
            this.rdoLarge.TabIndex = 0;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large 350\" + 100tk per";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(6, 61);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(156, 17);
            this.rdoMedium.TabIndex = 0;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium 200 + 70tk per item";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(6, 38);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(147, 17);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small 150 + 50tk per  item";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.rdoItemDeluxe);
            this.grpBox2.Controls.Add(this.rdoItem4);
            this.grpBox2.Controls.Add(this.rdoItem3);
            this.grpBox2.Controls.Add(this.rdoItem2);
            this.grpBox2.Controls.Add(this.rdoItem1);
            this.grpBox2.Location = new System.Drawing.Point(192, 67);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(117, 183);
            this.grpBox2.TabIndex = 1;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Items";
            // 
            // rdoItemDeluxe
            // 
            this.rdoItemDeluxe.AutoSize = true;
            this.rdoItemDeluxe.Location = new System.Drawing.Point(6, 132);
            this.rdoItemDeluxe.Name = "rdoItemDeluxe";
            this.rdoItemDeluxe.Size = new System.Drawing.Size(58, 17);
            this.rdoItemDeluxe.TabIndex = 0;
            this.rdoItemDeluxe.TabStop = true;
            this.rdoItemDeluxe.Text = "Deluxe";
            this.rdoItemDeluxe.UseVisualStyleBackColor = true;
            this.rdoItemDeluxe.CheckedChanged += new System.EventHandler(this.rdoItemDeluxe_CheckedChanged);
            // 
            // rdoItem4
            // 
            this.rdoItem4.AutoSize = true;
            this.rdoItem4.Location = new System.Drawing.Point(6, 109);
            this.rdoItem4.Name = "rdoItem4";
            this.rdoItem4.Size = new System.Drawing.Size(59, 17);
            this.rdoItem4.TabIndex = 0;
            this.rdoItem4.TabStop = true;
            this.rdoItem4.Text = "4 Items";
            this.rdoItem4.UseVisualStyleBackColor = true;
            this.rdoItem4.CheckedChanged += new System.EventHandler(this.rdoItem4_CheckedChanged);
            // 
            // rdoItem3
            // 
            this.rdoItem3.AutoSize = true;
            this.rdoItem3.Location = new System.Drawing.Point(6, 84);
            this.rdoItem3.Name = "rdoItem3";
            this.rdoItem3.Size = new System.Drawing.Size(59, 17);
            this.rdoItem3.TabIndex = 0;
            this.rdoItem3.TabStop = true;
            this.rdoItem3.Text = "3 Items";
            this.rdoItem3.UseVisualStyleBackColor = true;
            this.rdoItem3.CheckedChanged += new System.EventHandler(this.rdoItem3_CheckedChanged);
            // 
            // rdoItem2
            // 
            this.rdoItem2.AutoSize = true;
            this.rdoItem2.Location = new System.Drawing.Point(6, 61);
            this.rdoItem2.Name = "rdoItem2";
            this.rdoItem2.Size = new System.Drawing.Size(59, 17);
            this.rdoItem2.TabIndex = 0;
            this.rdoItem2.TabStop = true;
            this.rdoItem2.Text = "2 Items";
            this.rdoItem2.UseVisualStyleBackColor = true;
            this.rdoItem2.CheckedChanged += new System.EventHandler(this.rdoItem2_CheckedChanged);
            // 
            // rdoItem1
            // 
            this.rdoItem1.AutoSize = true;
            this.rdoItem1.Location = new System.Drawing.Point(6, 38);
            this.rdoItem1.Name = "rdoItem1";
            this.rdoItem1.Size = new System.Drawing.Size(54, 17);
            this.rdoItem1.TabIndex = 0;
            this.rdoItem1.TabStop = true;
            this.rdoItem1.Text = "1 Item";
            this.rdoItem1.UseVisualStyleBackColor = true;
            this.rdoItem1.CheckedChanged += new System.EventHandler(this.rdoItem1_CheckedChanged);
            // 
            // grpBox3
            // 
            this.grpBox3.Controls.Add(this.chkBoxCoupon);
            this.grpBox3.Controls.Add(this.chkBoxDelivery);
            this.grpBox3.Location = new System.Drawing.Point(315, 67);
            this.grpBox3.Name = "grpBox3";
            this.grpBox3.Size = new System.Drawing.Size(157, 111);
            this.grpBox3.TabIndex = 2;
            this.grpBox3.TabStop = false;
            this.grpBox3.Text = "Extras";
            // 
            // chkBoxCoupon
            // 
            this.chkBoxCoupon.AutoSize = true;
            this.chkBoxCoupon.Location = new System.Drawing.Point(18, 74);
            this.chkBoxCoupon.Name = "chkBoxCoupon";
            this.chkBoxCoupon.Size = new System.Drawing.Size(63, 17);
            this.chkBoxCoupon.TabIndex = 0;
            this.chkBoxCoupon.Text = "Coupon";
            this.chkBoxCoupon.UseVisualStyleBackColor = true;
            // 
            // chkBoxDelivery
            // 
            this.chkBoxDelivery.AutoSize = true;
            this.chkBoxDelivery.Location = new System.Drawing.Point(18, 38);
            this.chkBoxDelivery.Name = "chkBoxDelivery";
            this.chkBoxDelivery.Size = new System.Drawing.Size(64, 17);
            this.chkBoxDelivery.TabIndex = 0;
            this.chkBoxDelivery.Text = "Delivery";
            this.chkBoxDelivery.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(55, 287);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(76, 326);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(198, 326);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(328, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "AM PIZZA";
            // 
            // pizzaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBox3);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grpBox);
            this.Name = "pizzaMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pizzaMenu_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.grpBox3.ResumeLayout(false);
            this.grpBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.RadioButton rdoItemDeluxe;
        private System.Windows.Forms.RadioButton rdoItem4;
        private System.Windows.Forms.RadioButton rdoItem3;
        private System.Windows.Forms.RadioButton rdoItem2;
        private System.Windows.Forms.RadioButton rdoItem1;
        private System.Windows.Forms.GroupBox grpBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkBoxCoupon;
        private System.Windows.Forms.CheckBox chkBoxDelivery;
        private System.Windows.Forms.Label label2;
    }
}

