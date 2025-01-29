namespace PierceAuto.Forms
{
    partial class MainMenu
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
            productsButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // productsButton
            // 
            productsButton.Location = new System.Drawing.Point(14, 12);
            productsButton.Name = "productsButton";
            productsButton.Size = new System.Drawing.Size(181, 31);
            productsButton.TabIndex = 0;
            productsButton.Text = "Products";
            productsButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(208, 450);
            Controls.Add(productsButton);
            Location = new System.Drawing.Point(50, 100);
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button productsButton;
    }
}