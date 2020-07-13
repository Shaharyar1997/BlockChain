namespace BlockChain_Project
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createSmartContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySmartContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferOnwerShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceDecommisioningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSmartContractToolStripMenuItem,
            this.displaySmartContractToolStripMenuItem,
            this.transferOnwerShipToolStripMenuItem,
            this.deviceDecommisioningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // createSmartContractToolStripMenuItem
            // 
            this.createSmartContractToolStripMenuItem.Name = "createSmartContractToolStripMenuItem";
            this.createSmartContractToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.createSmartContractToolStripMenuItem.Text = "Create Smart Contract";
            this.createSmartContractToolStripMenuItem.Click += new System.EventHandler(this.createSmartContractToolStripMenuItem_Click);
            // 
            // displaySmartContractToolStripMenuItem
            // 
            this.displaySmartContractToolStripMenuItem.Name = "displaySmartContractToolStripMenuItem";
            this.displaySmartContractToolStripMenuItem.Size = new System.Drawing.Size(200, 29);
            this.displaySmartContractToolStripMenuItem.Text = "DisplaySmartContract";
            this.displaySmartContractToolStripMenuItem.Click += new System.EventHandler(this.displaySmartContractToolStripMenuItem_Click);
            // 
            // transferOnwerShipToolStripMenuItem
            // 
            this.transferOnwerShipToolStripMenuItem.Name = "transferOnwerShipToolStripMenuItem";
            this.transferOnwerShipToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.transferOnwerShipToolStripMenuItem.Text = "TransferOnwerShip";
            this.transferOnwerShipToolStripMenuItem.Click += new System.EventHandler(this.transferOnwerShipToolStripMenuItem_Click);
            // 
            // deviceDecommisioningToolStripMenuItem
            // 
            this.deviceDecommisioningToolStripMenuItem.Name = "deviceDecommisioningToolStripMenuItem";
            this.deviceDecommisioningToolStripMenuItem.Size = new System.Drawing.Size(220, 29);
            this.deviceDecommisioningToolStripMenuItem.Text = "Device Decommisioning";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createSmartContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySmartContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferOnwerShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceDecommisioningToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}