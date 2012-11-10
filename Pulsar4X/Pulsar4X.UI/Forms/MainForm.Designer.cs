﻿namespace Pulsar4X.UI.Forms
{
    partial class MainForm
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
            this.m_oMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.m_oToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.m_oMainToolStrip = new System.Windows.Forms.ToolStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_oMainMenuStrip.SuspendLayout();
            this.m_oToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.m_oToolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_oMainMenuStrip
            // 
            this.m_oMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.spaceMasterToolStripMenuItem,
            this.empireToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.m_oMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.m_oMainMenuStrip.Name = "m_oMainMenuStrip";
            this.m_oMainMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.m_oMainMenuStrip.TabIndex = 0;
            this.m_oMainMenuStrip.Text = "menuStrip1";
            // 
            // m_oToolStripContainer
            // 
            // 
            // m_oToolStripContainer.ContentPanel
            // 
            this.m_oToolStripContainer.ContentPanel.Size = new System.Drawing.Size(1008, 681);
            this.m_oToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_oToolStripContainer.Location = new System.Drawing.Point(0, 24);
            this.m_oToolStripContainer.Name = "m_oToolStripContainer";
            this.m_oToolStripContainer.Size = new System.Drawing.Size(1008, 706);
            this.m_oToolStripContainer.TabIndex = 1;
            this.m_oToolStripContainer.Text = "toolStripContainer1";
            // 
            // m_oToolStripContainer.TopToolStripPanel
            // 
            this.m_oToolStripContainer.TopToolStripPanel.Controls.Add(this.m_oMainToolStrip);
            // 
            // m_oMainToolStrip
            // 
            this.m_oMainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.m_oMainToolStrip.Location = new System.Drawing.Point(3, 0);
            this.m_oMainToolStrip.Name = "m_oMainToolStrip";
            this.m_oMainToolStrip.Size = new System.Drawing.Size(111, 25);
            this.m_oMainToolStrip.TabIndex = 0;
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // spaceMasterToolStripMenuItem
            // 
            this.spaceMasterToolStripMenuItem.Name = "spaceMasterToolStripMenuItem";
            this.spaceMasterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.spaceMasterToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.spaceMasterToolStripMenuItem.Text = "&Space Master";
            // 
            // empireToolStripMenuItem
            // 
            this.empireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemInformationToolStripMenuItem});
            this.empireToolStripMenuItem.Name = "empireToolStripMenuItem";
            this.empireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.empireToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.empireToolStripMenuItem.Text = "&Empire";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // systemInformationToolStripMenuItem
            // 
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.systemInformationToolStripMenuItem.Text = "System Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.m_oToolStripContainer);
            this.Controls.Add(this.m_oMainMenuStrip);
            this.MainMenuStrip = this.m_oMainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Text = "Pulsar4X";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.m_oMainMenuStrip.ResumeLayout(false);
            this.m_oMainMenuStrip.PerformLayout();
            this.m_oToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.m_oToolStripContainer.TopToolStripPanel.PerformLayout();
            this.m_oToolStripContainer.ResumeLayout(false);
            this.m_oToolStripContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_oMainMenuStrip;
        private System.Windows.Forms.ToolStripContainer m_oToolStripContainer;
        private System.Windows.Forms.ToolStrip m_oMainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
    }
}