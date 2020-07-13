namespace BlockChain_Project
{
    partial class PatientMenu
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
            this.transferOwnerShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decommisioningDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferOwnerShipToolStripMenuItem,
            this.decommisioningDeviceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transferOwnerShipToolStripMenuItem
            // 
            this.transferOwnerShipToolStripMenuItem.Name = "transferOwnerShipToolStripMenuItem";
            this.transferOwnerShipToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.transferOwnerShipToolStripMenuItem.Text = "TransferOwnerShip";
            this.transferOwnerShipToolStripMenuItem.Click += new System.EventHandler(this.transferOwnerShipToolStripMenuItem_Click);
            // 
            // decommisioningDeviceToolStripMenuItem
            // 
            this.decommisioningDeviceToolStripMenuItem.Name = "decommisioningDeviceToolStripMenuItem";
            this.decommisioningDeviceToolStripMenuItem.Size = new System.Drawing.Size(220, 29);
            this.decommisioningDeviceToolStripMenuItem.Text = "Decommisioning Device";
            this.decommisioningDeviceToolStripMenuItem.Click += new System.EventHandler(this.decommisioningDeviceToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // PatientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientMenu";
            this.Text = "PatientMenu";
            this.Load += new System.EventHandler(this.PatientMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transferOwnerShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decommisioningDeviceToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}