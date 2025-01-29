namespace PierceAuto.Views
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            findToolStripButton = new System.Windows.Forms.ToolStripButton();
            addToolStripButton = new System.Windows.Forms.ToolStripButton();
            firstRecordToolStripButton = new System.Windows.Forms.ToolStripButton();
            previousRecordToolStripButton = new System.Windows.Forms.ToolStripButton();
            nextRecordToolStripButton = new System.Windows.Forms.ToolStripButton();
            lastRecordToolStripButton = new System.Windows.Forms.ToolStripButton();
            refreshRecordToolStripButton = new System.Windows.Forms.ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, windowsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.MdiWindowListItem = windowsToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1227, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            windowsToolStripMenuItem.Text = "&Windows";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 768);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1227, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { findToolStripButton, addToolStripButton, firstRecordToolStripButton, previousRecordToolStripButton, nextRecordToolStripButton, lastRecordToolStripButton, refreshRecordToolStripButton });
            toolStrip1.Location = new System.Drawing.Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1227, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // findToolStripButton
            // 
            findToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            findToolStripButton.Enabled = false;
            findToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("findToolStripButton.Image"));
            findToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            findToolStripButton.Name = "findToolStripButton";
            findToolStripButton.Size = new System.Drawing.Size(23, 22);
            findToolStripButton.Text = "Find";
            // 
            // addToolStripButton
            // 
            addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            addToolStripButton.Enabled = false;
            addToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("addToolStripButton.Image"));
            addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            addToolStripButton.Name = "addToolStripButton";
            addToolStripButton.Size = new System.Drawing.Size(23, 22);
            addToolStripButton.Text = "Add";
            // 
            // firstRecordToolStripButton
            // 
            firstRecordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            firstRecordToolStripButton.Enabled = false;
            firstRecordToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("firstRecordToolStripButton.Image"));
            firstRecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            firstRecordToolStripButton.Name = "firstRecordToolStripButton";
            firstRecordToolStripButton.Size = new System.Drawing.Size(23, 22);
            firstRecordToolStripButton.Text = "First Record";
            // 
            // previousRecordToolStripButton
            // 
            previousRecordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            previousRecordToolStripButton.Enabled = false;
            previousRecordToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("previousRecordToolStripButton.Image"));
            previousRecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            previousRecordToolStripButton.Name = "previousRecordToolStripButton";
            previousRecordToolStripButton.Size = new System.Drawing.Size(23, 22);
            previousRecordToolStripButton.Text = "Previous Record";
            // 
            // nextRecordToolStripButton
            // 
            nextRecordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            nextRecordToolStripButton.Enabled = false;
            nextRecordToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("nextRecordToolStripButton.Image"));
            nextRecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            nextRecordToolStripButton.Name = "nextRecordToolStripButton";
            nextRecordToolStripButton.Size = new System.Drawing.Size(23, 22);
            nextRecordToolStripButton.Text = "NextRecord";
            // 
            // lastRecordToolStripButton
            // 
            lastRecordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            lastRecordToolStripButton.Enabled = false;
            lastRecordToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("lastRecordToolStripButton.Image"));
            lastRecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            lastRecordToolStripButton.Name = "lastRecordToolStripButton";
            lastRecordToolStripButton.Size = new System.Drawing.Size(23, 22);
            lastRecordToolStripButton.Text = "Last Record";
            // 
            // refreshRecordToolStripButton
            // 
            refreshRecordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            refreshRecordToolStripButton.Enabled = false;
            refreshRecordToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("refreshRecordToolStripButton.Image"));
            refreshRecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            refreshRecordToolStripButton.Name = "refreshRecordToolStripButton";
            refreshRecordToolStripButton.Size = new System.Drawing.Size(23, 22);
            refreshRecordToolStripButton.Text = "Refresh Record";
            refreshRecordToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1227, 790);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Text = "Pierce Automotive, Inc";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ToolStripButton findToolStripButton;
        private ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton firstRecordToolStripButton;
        private System.Windows.Forms.ToolStripButton previousRecordToolStripButton;
        private System.Windows.Forms.ToolStripButton nextRecordToolStripButton;
        private System.Windows.Forms.ToolStripButton lastRecordToolStripButton;
        private ToolStripButton refreshRecordToolStripButton;
    }
}
