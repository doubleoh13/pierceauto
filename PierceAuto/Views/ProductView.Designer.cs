namespace PierceAuto.Forms
{
    partial class ProductView
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtSKU = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btn1 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            txtPrice = new PierceAuto.CurrencyTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Part Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // txtSKU
            // 
            txtSKU.Location = new System.Drawing.Point(94, 12);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new System.Drawing.Size(211, 23);
            txtSKU.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(94, 41);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(211, 23);
            txtDescription.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 78);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // btn1
            // 
            btn1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            btn1.Location = new System.Drawing.Point(12, 114);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(75, 23);
            btn1.TabIndex = 7;
            btn1.Text = "OK";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            btn2.Location = new System.Drawing.Point(93, 114);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(75, 23);
            btn2.TabIndex = 8;
            btn2.Text = "Cancel";
            btn2.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(93, 70);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(212, 23);
            txtPrice.TabIndex = 9;
            txtPrice.Text = "0.00";
            txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(345, 149);
            Controls.Add(txtPrice);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtSKU);
            Text = "Product";
            ResumeLayout(false);
            PerformLayout();
        }

        private PierceAuto.CurrencyTextBox txtPrice;
        private TextBox txtSKU;
        private TextBox txtDescription;
        private Label label2;
        private Label label1;
        private Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;

        #endregion

    }
}